using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class RolePermissionMap:EntityTypeConfiguration<RolePermission>
    {
        public RolePermissionMap()
        {
            ToTable("RolePermission");
            HasKey(t=>t.Id);
            
        }
    }
}
