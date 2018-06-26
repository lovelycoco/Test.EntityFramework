using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Test;

namespace Test.EntityFramework.Maps
{
    public class UserRoleMap:EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            ToTable("UserRole");
            HasKey(t => t.Id);
            Property(t => t.IsEnabled).IsConcurrencyToken();
        }
    }
}
