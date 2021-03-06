﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class PermissionMap : EntityTypeConfiguration<Permission>
    {
        public PermissionMap()
        {
            ToTable("Permission");
            HasKey(t => t.Id);

            Property(t => t.PermissionName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.FeatureName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.Description).IsOptional().HasMaxLength(256).IsConcurrencyToken();
            Property(t => t.IsEnabled).IsConcurrencyToken();
            HasMany(t => t.RolePermissions).WithRequired(r => r.Permission).HasForeignKey(r => r.PermissionId).WillCascadeOnDelete(false);

            HasMany(t => t.PermissionMenuLists).WithRequired(p => p.Permission).HasForeignKey(k => k.PermissionId).WillCascadeOnDelete(false);
        }
    }
}
