using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class UnitPriceMap:EntityTypeConfiguration<UnitPrice>
    {
        public UnitPriceMap()
        {
            ToTable("UnitPrice");
            HasKey(t => t.Id);

            Property(t=>t.Amount).IsRequired().HasPrecision(18, 4).IsConcurrencyToken();
            HasOptional(t => t.Material).WithOptionalDependent(u => u.UnitPrice).Map(x => x.MapKey("MaterialId")).WillCascadeOnDelete(false);
        }
    }
}
