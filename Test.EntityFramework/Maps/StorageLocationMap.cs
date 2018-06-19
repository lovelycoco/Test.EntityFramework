using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class StorageLocationMap:EntityTypeConfiguration<StorageLocation>
    {
        public StorageLocationMap()
        {
            ToTable("StorageLocation");
            HasKey(t=>t.Id);

            Property(t => t.LocationCode).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            Property(t => t.LocationName).IsRequired().HasMaxLength(50);

            HasMany(t => t.UserStorageLocations).WithRequired(s => s.StorageLocation).HasForeignKey(k => k.SotrageLocationId);

            HasOptional(t => t.Material).WithOptionalPrincipal(s => s.StorageLocation);

        }
    }
}
