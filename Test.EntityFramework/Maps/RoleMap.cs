using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class RoleMap:EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable("Role");
            HasKey(t=>t.Id);

            Property(t=>t.RoleName).IsRequired().HasMaxLength(50);
           
        }
    }
}
