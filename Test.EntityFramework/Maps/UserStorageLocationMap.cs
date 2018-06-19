using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class UserStorageLocationMap:EntityTypeConfiguration<UserStorageLocation>
    {
        public UserStorageLocationMap()
        {
            ToTable("UserStorageLocation");
            HasKey(t=>t.Id);
        }
    }
}
