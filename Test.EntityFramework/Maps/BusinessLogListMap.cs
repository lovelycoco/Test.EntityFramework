using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class BusinessLogListMap:EntityTypeConfiguration<BusinessLogList>
    {
        public BusinessLogListMap()
        {
            ToTable("BusinessLogList");
            HasKey(t => t.Id);

            Property(t => t.ModifiedField).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            Property(t => t.ModifiedFieldName).IsRequired().HasMaxLength(50);
            Property(t => t.OriginalValue).IsRequired().HasMaxLength(256);
            Property(t => t.TargetValue).IsRequired().HasMaxLength(256);
        }
    }
}
