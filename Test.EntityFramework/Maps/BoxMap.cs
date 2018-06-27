using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class BoxMap : EntityTypeConfiguration<Box>
    {
        public BoxMap()
        {
            ToTable("Box");
            HasKey(t => t.Id);
            Property(t => t.BoxNo).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsConcurrencyToken();
            HasRequired(t => t.BoxType).WithMany(d => d.BoxeTypes).HasForeignKey(t => t.BoxTypeId).WillCascadeOnDelete(false);
        }
    }
}
