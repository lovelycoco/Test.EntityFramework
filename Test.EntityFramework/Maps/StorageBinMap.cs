using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class StorageBinMap:EntityTypeConfiguration<StorageBin>
    {
        public StorageBinMap()
        {
            ToTable("StorageBin");
            HasKey(t=>t.Id);

            Property(t => t.BinCode).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.BinName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.IsEnabled).IsConcurrencyToken();
            HasMany(t => t.UserStorageBins).WithRequired(s => s.StorageBin).HasForeignKey(k => k.StorageBinId).WillCascadeOnDelete(false);
            
            Map<EntityStorageBin>(e => e.Requires("BinType").HasValue(1)).Map<VirtualStorageBin>(r => r.Requires("BinType").HasValue(2));

        }
    }
}
