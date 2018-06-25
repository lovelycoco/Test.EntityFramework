using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class OperatorLogMap : EntityTypeConfiguration<OperatorLog>
    {
        public OperatorLogMap()
        {
            ToTable("OperatorLog");
            HasKey(t => t.Id);

            Property(t => t.Operation).IsRequired().HasMaxLength(50);
            Property(t => t.Memo).IsRequired().HasMaxLength(256).IsConcurrencyToken();

            HasRequired(t => t.OperatorCode).WithMany(d => d.OperatorCodes).HasForeignKey(t => t.CodeId).WillCascadeOnDelete(false);
            HasRequired(t => t.LogLevel).WithMany(d => d.OperatorLogLevels).HasForeignKey(t => t.LevelId).WillCascadeOnDelete(false);
        }
    }
}
