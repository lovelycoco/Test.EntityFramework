using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class MenuListMap : EntityTypeConfiguration<MenuList>
    {
        public MenuListMap()
        {
            ToTable("MenuList");
            HasKey(t => t.Id);

            Property(t => t.MenuName).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.DisplayName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.MenuDescription).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.MenuURL).IsRequired().HasMaxLength(256).IsConcurrencyToken();
            Property(t => t.IsEnabled).IsConcurrencyToken();
            Property(t => t.MenuIcon).IsRequired().HasColumnType("image").IsConcurrencyToken();

            HasMany(t => t.PermissionMenuLists).WithRequired(p => p.MenuList).HasForeignKey(k => k.MenuListId).WillCascadeOnDelete(false);
        }
    }
}
