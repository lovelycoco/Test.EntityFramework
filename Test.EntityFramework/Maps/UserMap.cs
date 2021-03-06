﻿using System;
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

            Property(t => t.LoginName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.UserName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.Password).IsRequired().HasColumnType("varchar").HasMaxLength(100).IsConcurrencyToken();
            Property(t => t.Email).HasColumnType("varchar").HasMaxLength(256).IsConcurrencyToken();
            Property(t => t.PhoneNumber).HasColumnType("varchar").HasMaxLength(13).IsConcurrencyToken();
            Property(t => t.IsEnabled).IsConcurrencyToken();
            Property(t => t.HeadPortrait).HasColumnType("image");
            Property(t => t.IDCard).HasColumnType("varchar").HasMaxLength(18).IsConcurrencyToken();
            Property(t => t.IsQuited).IsConcurrencyToken();


            HasMany(t => t.UserStorageBins).WithRequired(s => s.User).HasForeignKey(k => k.UserId).WillCascadeOnDelete(false);
            HasMany(t => t.UserRoles).WithRequired(u => u.User).HasForeignKey(k => k.UserId).WillCascadeOnDelete(false);
           
        }
    }
}
