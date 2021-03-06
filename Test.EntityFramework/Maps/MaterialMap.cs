﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class MaterialMap : EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
            ToTable("Material");
            HasKey(t => t.Id);

            Property(t => t.MaterialNo).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.MaterialName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.UnitPrice).IsRequired().HasPrecision(18, 4).IsConcurrencyToken();
            Property(t => t.IsEnabled).IsConcurrencyToken();
            HasRequired(t => t.Supplier).WithMany(s => s.Materials).HasForeignKey(t => t.SupplierId).WillCascadeOnDelete(false);

            HasOptional(m => m.StorageBin).WithOptionalDependent(m => m.Material).Map(x => x.MapKey("StorageBinId")).WillCascadeOnDelete(false);
            HasOptional(t => t.PreEntry).WithOptionalPrincipal(p => p.Material).Map(x => x.MapKey("MaterialId")).WillCascadeOnDelete(false);
           

            HasRequired(t => t.MaterialType).WithMany(d => d.MaterialTypes).HasForeignKey(t => t.MaterialTypeId).WillCascadeOnDelete(false);
            HasMany(t => t.MaterialLists).WithRequired(m => m.Material).HasForeignKey(m => m.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.PickupLists).WithRequired(p => p.Material).HasForeignKey(p => p.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.NoteLists).WithRequired(n => n.Material).HasForeignKey(n => n.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.TemplateLists).WithRequired(t => t.Material).HasForeignKey(t => t.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.BadGoods).WithRequired(b => b.Material).HasForeignKey(b => b.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.SelfPickupLists).WithRequired(s => s.Material).HasForeignKey(s => s.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.Stocks).WithRequired(s => s.Material).HasForeignKey(s => s.MaterialId).WillCascadeOnDelete(false);
            HasMany(t => t.Accounts).WithRequired(a => a.Material).HasForeignKey(a => a.MaterialId).WillCascadeOnDelete(false);
        }
    }
}
