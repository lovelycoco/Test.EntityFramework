using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            ToTable("Stock");
            HasKey(t => t.Id);
        }
    }
}
