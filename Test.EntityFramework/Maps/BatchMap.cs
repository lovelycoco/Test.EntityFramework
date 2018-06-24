using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class BatchMap : EntityTypeConfiguration<Batch>
    {
        public BatchMap()
        {
            ToTable("Batch");
            HasKey(t => t.Id);
            Property(t => t.BatchNo).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            Property(t => t.IsBlocked).IsConcurrencyToken();
            HasMany(t => t.MaterialLists).WithRequired(b => b.Batch).HasForeignKey(b => b.BatchId).WillCascadeOnDelete(false);
        }
    }
}
