using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class CycleCountMap : EntityTypeConfiguration<CycleCount>
    {
        public CycleCountMap()
        {
            ToTable("CycleCount");
            HasKey(t => t.Id);

            Property(t => t.IsVisual).IsConcurrencyToken();
            Property(t => t.Memo).IsOptional().HasMaxLength(256).IsConcurrencyToken();

            HasRequired(t => t.StorageBin).WithMany(s => s.CycleCounts).HasForeignKey(t => t.StorageBinId).WillCascadeOnDelete(false);
            HasRequired(t => t.CountType).WithMany(d => d.CountTypes).HasForeignKey(t => t.TypeId).WillCascadeOnDelete(false);
        }

    }
}
