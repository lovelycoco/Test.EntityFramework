using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class MaterialListMap : EntityTypeConfiguration<MaterialList>
    {
        public MaterialListMap()
        {
            ToTable("MaterialList");
            HasKey(t => t.Id);
            //Property(t => t.).IsRequired().HasColumnType("varchar").HasMaxLength(50);

            HasRequired(t => t.MaterialStatus).WithMany(d => d.MaterialLists).HasForeignKey(t => t.DataDictionaryInfoId).WillCascadeOnDelete(false);
            HasMany(t => t.Traces).WithRequired(t => t.MaterialList).HasForeignKey(t => t.MaterialListId).WillCascadeOnDelete(false);
            //HasOptional(t => t.Tag).WithOptionalDependent(t => t.MaterialList).Map(x => x.MapKey("TagId")).WillCascadeOnDelete(false);
            HasOptional(t => t.Box).WithOptionalDependent(t => t.MaterialList).Map(x => x.MapKey("BoxId")).WillCascadeOnDelete(false);
        }

    }
}
