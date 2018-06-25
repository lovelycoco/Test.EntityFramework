using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class SelfPickupMap : EntityTypeConfiguration<SelfPickup>
    {
        public SelfPickupMap()
        {
            ToTable("SelfPickup");
            HasKey(t => t.Id);

            Property(t => t.SelfPeople).IsRequired().HasMaxLength(10).IsConcurrencyToken();
            Property(t => t.IsPrinted).IsConcurrencyToken();

            HasRequired(t => t.Supplier).WithMany(s => s.SelfPickups).HasForeignKey(t => t.SupplierId).WillCascadeOnDelete(false);
            HasMany(t => t.SelfPickupLists).WithRequired(s => s.SelfPickup).HasForeignKey(t => t.SelfId).WillCascadeOnDelete(false);
            HasRequired(t => t.OriginalType).WithMany(d => d.OriginalTypes).HasForeignKey(t => t.TypeId).WillCascadeOnDelete(false);
        }
    }
}
