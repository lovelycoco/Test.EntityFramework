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
            HasRequired(t => t.PickUpType).WithMany(d => d.PickupTypes).HasForeignKey(t => t.TypeId).WillCascadeOnDelete(false);
            HasRequired(t => t.PickupStatus).WithMany(d => d.PickupStatuses).HasForeignKey(t => t.StatusId).WillCascadeOnDelete(false);
            HasRequired(t => t.AreaType).WithMany(d => d.PickupAreaTypes).HasForeignKey(t => t.AreaId).WillCascadeOnDelete(false);

            //Map<StorageAreaPickup>(e => e.Requires("AreaType").HasValue(1)).Map<PickingAreaPickup>(r => r.Requires("AreaType").HasValue(2));
        }
    }
}
