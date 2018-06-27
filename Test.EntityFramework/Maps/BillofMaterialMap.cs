using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class BillofMaterialMap:EntityTypeConfiguration<BillofMaterial>
    {
        public BillofMaterialMap()
        {
            ToTable("BillofMaterial");
            HasKey(t => t.Id);

            Property(t => t.BillNo).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            Property(t => t.Memo).IsOptional().HasMaxLength(256);
            HasMany(t => t.MaterialLists).WithRequired(m => m.BillofMaterial).HasForeignKey(m => m.BillOfMaterialId).WillCascadeOnDelete(false);
        }
    }
}
