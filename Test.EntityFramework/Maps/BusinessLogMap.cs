using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class BusinessLogMap : EntityTypeConfiguration<BusinessLog>
    {
        public BusinessLogMap()
        {
            ToTable("BusinessLog");
            HasKey(t=>t.Id);

            Property(t => t.OperationTable).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            Property(t => t.Memo).IsOptional().HasMaxLength(256);

            HasRequired(t => t.BusinessType).WithMany(d => d.BusinessTypes).HasForeignKey(t=>t.TypeId).WillCascadeOnDelete(false);
            HasRequired(t => t.OperationCode).WithMany(d => d.BusinessOperationCodes).HasForeignKey(t => t.CodeId).WillCascadeOnDelete(false);

            HasMany(t => t.BusinessLogLists).WithRequired(b => b.BusinessLog).HasForeignKey(b => b.BusinessLogId).WillCascadeOnDelete(false);
        }
    }
}
