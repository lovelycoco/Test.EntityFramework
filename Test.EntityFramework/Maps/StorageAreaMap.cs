using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class StorageAreaMap : EntityTypeConfiguration<StorageArea>
    {
        public StorageAreaMap()
        {
            ToTable("StorageArea");
            HasKey(t => t.Id);

            Property(t => t.AreaCode).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.AreaName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.AreaDescription).IsOptional().HasMaxLength(256).IsConcurrencyToken();
            Property(t => t.IsEnabled).IsConcurrencyToken();

            HasMany(t => t.StorageBins).WithRequired(s => s.StorageArea).HasForeignKey(s => s.StorageAreaId).WillCascadeOnDelete(false);
            Map<EntityStorageArea>(e => e.Requires("AreaType").HasValue(1)).Map<VirtualStorageArea>(r => r.Requires("AreaType").HasValue(2));
        }
    }
}
