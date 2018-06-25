using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class PickupTemplateMap : EntityTypeConfiguration<PickupTemplate>
    {
        public PickupTemplateMap()
        {
            ToTable("PickupTemplate");
            HasKey(t => t.Id);

            Property(t => t.TemplateName).IsRequired().HasMaxLength(256).IsConcurrencyToken();
            HasMany(t => t.TemplateLists).WithRequired(p => p.PickupTemplate).HasForeignKey(p => p.TemplateId).WillCascadeOnDelete(false);
            HasRequired(t => t.TemplateType).WithMany(d => d.TemplateTypes).HasForeignKey(t => t.TypeId).WillCascadeOnDelete(false);
        }
    }
}
