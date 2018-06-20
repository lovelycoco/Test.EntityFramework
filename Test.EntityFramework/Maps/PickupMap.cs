using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class PickupMap : EntityTypeConfiguration<Pickup>
    {
        public PickupMap()
        {
            ToTable("Pickup");
            HasKey(t => t.Id);

            Property(t => t.PickupNo).IsRequired().HasColumnType("varchar").HasMaxLength(50);

            HasMany(t => t.PickupLists).WithRequired(p => p.PickingList).HasForeignKey(p => p.PickingListId).WillCascadeOnDelete(false);
            Map<StorageAreaPickup>(e => e.Requires("PickupType").HasValue(1)).Map<PickingAreaPickup>(r => r.Requires("PickupType").HasValue(2));
        }
    }
}
