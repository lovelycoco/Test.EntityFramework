using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class PickupListMap:EntityTypeConfiguration<PickupList>
    {
        public PickupListMap()
        {
            ToTable("PickupList");
            HasKey(t=>t.Id);
            


        }
    }
}
