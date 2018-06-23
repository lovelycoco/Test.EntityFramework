using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");
            HasKey(t => t.Id);

            Property(t=>t.UserName).IsRequired().HasMaxLength(256);
            Property(t => t.NormalizedUserName).IsRequired().HasMaxLength(256);
            Property(t => t.Password).IsRequired().HasColumnType("varchar").HasMaxLength(256);
            Property(t => t.Email).HasColumnType("varchar").HasMaxLength(256);

        }
    }
}
