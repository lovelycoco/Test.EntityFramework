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

            Property(t => t.MaterialNum).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            Property(t => t.MaterialName).IsRequired().HasMaxLength(50);

            HasRequired(t => t.Supplier).WithMany(s => s.Materials).HasForeignKey(t => t.SupplierId).WillCascadeOnDelete(false);

            HasOptional(x => x.StorageBin).WithOptionalDependent(s => s.Material).Map(x => x.MapKey("StorageBinId"));

            //HasOptional(t => t.MaterialType).WithOptionalDependent(s => s.Material).Map(x => x.MapKey("DataDictionaryInfoId"));

            HasRequired(t => t.DataDictionaryInfo).WithMany(d => d.Materials).HasForeignKey(t => t.DataDictionaryInfoId).WillCascadeOnDelete(false);
        }
    }
}
