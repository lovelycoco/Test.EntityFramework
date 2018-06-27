﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test.EntityFramework
{
    public static class ContextExtensions
    {
        public static string GetTableName(this DbContext context, Type tableType)
        {
            MethodInfo method = typeof(ContextExtensions).GetMethod("GetTableName", new Type[] { typeof(DbContext) })
                .MakeGenericMethod(new Type[] { tableType });

            return (string)method.Invoke(context, new object[] { context });
        }

        public static string GetTableName<T>(this DbContext context) where T : class
        {
            ObjectContext objectContext = ((IObjectContextAdapter)context).ObjectContext;

            return objectContext.GetTableName<T>();
        }

        public static string GetTableName<T>(this ObjectContext context) where T : class
        {
            string sql = context.CreateObjectSet<T>().ToTraceString();
            Regex regex = new Regex("FROM (?<table>.*) AS");
            Match match = regex.Match(sql);

            string table = match.Groups["table"].Value;
            return table;
        }
    }
}
