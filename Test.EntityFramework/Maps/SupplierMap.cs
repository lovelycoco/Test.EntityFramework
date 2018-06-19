using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            ToTable("Supplier");
            HasKey(t => t.Id);
            Property(t => t.SupplierName).IsRequired().HasMaxLength(50);
            Property(t => t.SupplierCode).IsRequired().HasColumnType("varchar").HasMaxLength(50);

           
        }
    }
}
