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
            Property(t => t.BillOrder).IsRequired().HasColumnType("varchar").HasMaxLength(50);

        }

    }
}
