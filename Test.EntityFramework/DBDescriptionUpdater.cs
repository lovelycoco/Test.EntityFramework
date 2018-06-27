using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Test.Core;

namespace Test.EntityFramework
{
    public class DBDescriptionUpdater<TContext> where TContext : DbContext
    {
        private TContext context;
        private DbTransaction transaction;

        public DBDescriptionUpdater(TContext context)
        {
            this.context = context;
        }

        public void UpdateDatabaseDescriptions()
        {
            var contextType = typeof(TContext);
            var props = contextType.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            transaction = null;

            try
            {
                context.Database.Connection.Open();
                transaction = context.Database.Connection.BeginTransaction();

                foreach (var prop in props)
                {
                    if (prop.PropertyType.InheritsOrImplements((typeof(DbSet<>))))
                    {
                        var tableType = prop.PropertyType.GetGenericArguments()[0];
                        SetTableDescriptions(tableType);
                    }
                }

                transaction.Commit();
            }
            catch
            {
                if (transaction != null)
                    transaction.Rollback();

                throw;
            }
            finally
            {
                context.Database.Connection.Close();
            }
        }

        private void SetTableDescriptions(Type tableType)
        {
            string fullTableName = context.GetTableName(tableType);

            Regex regex = new Regex(@"(\[\w+\]\.)?\[(?<table>.*)\]");
            Match match = regex.Match(fullTableName);

            var tableName = match.Success ? match.Groups["table"].Value : fullTableName;
            var tableAttrs = tableType.GetCustomAttributes(typeof(TableAttribute), false);

            if (tableAttrs.Length > 0)
                tableName = ((TableAttribute)tableAttrs[0]).Name;

            var dbTableDescattr = tableType.GetCustomAttribute(typeof(DBDescriptionAttribute), false);
            string tableComment = ((DBDescriptionAttribute)dbTableDescattr).Description;

            if (!string.IsNullOrEmpty(tableComment))
                SetDBDescription(tableName, null, tableComment);

            foreach (var prop in tableType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var dbDescAttr = prop.GetCustomAttribute(typeof(DBDescriptionAttribute), false);

                if (dbDescAttr == null) continue;

                var columnNameAttr = prop.GetCustomAttribute(typeof(ColumnAttribute), false);

                if (columnNameAttr != null)
                {
                    var columnName = ((ColumnAttribute)columnNameAttr).Name;
                    SetDBDescription(tableName, string.IsNullOrEmpty(columnName) ? prop.Name : columnName,
                        ((DBDescriptionAttribute)dbDescAttr).Description);
                }

                else
                {
                    SetDBDescription(tableName, prop.Name, ((DBDescriptionAttribute)dbDescAttr).Description);
                }
            }

        }

        private void SetDBDescription(string tableName, string columnName, string description)
        {
            string desc = string.Empty;

            if (string.IsNullOrEmpty(columnName))
                desc = "select [value] from fn_listextendedproperty('MS_Description','schema','dbo','table',N'" + tableName + "',null,null);";
            else
                desc = "select [value] from fn_listextendedproperty('MS_Description','schema','dbo','table',N'" + tableName + "','column',null) where objname = N'" + columnName + "';";

            var prevDesc = (string)RunSqlScalar(desc);

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@table", tableName),
                new SqlParameter("@desc", description)
            };

            string funcName = "sp_addextendedproperty";

            if (!string.IsNullOrEmpty(prevDesc))
                funcName = "sp_updateextendedproperty";

        string query = @"EXEC " + funcName + @" N'MS_Description', @desc, N'Schema', 'dbo', N'Table', @table";

            if (!string.IsNullOrEmpty(columnName))
            {
                query += ", N'Column', @column";
                parameters.Add(new SqlParameter("@column", columnName));
            }

            RunSql(query, parameters.ToArray());
        }

        DbCommand CreateCommand(string cmdText, params SqlParameter[] parameters)
        {
            var cmd = context.Database.Connection.CreateCommand();
            cmd.CommandText = cmdText;
            cmd.Transaction = transaction;

            foreach (var p in parameters)
                cmd.Parameters.Add(p);

            return cmd;
        }

        void RunSql(string cmdText, params SqlParameter[] parameters)
        {
            var cmd = CreateCommand(cmdText, parameters);
            cmd.ExecuteNonQuery();
        }
        object RunSqlScalar(string cmdText, params SqlParameter[] parameters)
        {
            var cmd = CreateCommand(cmdText, parameters);
            return cmd.ExecuteScalar();
        }
    }
}
