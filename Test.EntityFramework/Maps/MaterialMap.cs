using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class MaterialMap : EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
            ToTable("Material");
            HasKey(t => t.Id);

            Property(t => t.MaterialNo).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.MaterialName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.IsEnabled).IsConcurrencyToken();
            HasRequired(t => t.Supplier).WithMany(s => s.Materials).HasForeignKey(t => t.SupplierId).WillCascadeOnDelete(false);

            HasOptional(x => x.StorageBin).WithOptionalDependent(s => s.Material).Map(x => x.MapKey("StorageBinId")).WillCascadeOnDelete(false);

            //HasOptional(t => t.MaterialType).WithOptionalDependent(s => s.Material).Map(x => x.MapKey("DataDictionaryInfoId"));

            HasRequired(t => t.MaterialType).WithMany(d => d.Materials).HasForeignKey(t => t.DataDictionaryInfoId).WillCascadeOnDelete(false);
            HasMany(t => t.MaterialLists).WithRequired(m => m.Material).HasForeignKey(m => m.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.PickupLists).WithRequired(p => p.Material).HasForeignKey(p => p.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.NoteLists).WithRequired(n => n.Material).HasForeignKey(n => n.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.TemplateLists).WithRequired(t => t.Material).HasForeignKey(t => t.MaterialId).WillCascadeOnDelete(false);

        }
    }
}
