using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class DataDictionaryInfoMap : EntityTypeConfiguration<DataDictionaryInfo>
    {
        public DataDictionaryInfoMap()
        {
            ToTable("DataDictionaryInfo");
            HasKey(t => t.Id);

            Property(t => t.DictionaryCode).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            Property(t => t.DictionaryDescription).IsRequired().HasMaxLength(256);
        }
    }
}
