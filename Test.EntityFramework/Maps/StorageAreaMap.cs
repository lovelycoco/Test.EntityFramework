using System;
using System.Collections.Generic;
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

            Property(t => t.AreaCode).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            Property(t => t.AreaName).IsRequired().HasMaxLength(50);
            Property(t => t.Description).IsOptional().HasMaxLength(255);

            HasMany(t => t.StorageLocations).WithRequired(s => s.StorageArea).HasForeignKey(s => s.StorageAreaId).WillCascadeOnDelete(false);

        }
    }
}
