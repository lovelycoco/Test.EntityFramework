using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class DataDictionaryMap : EntityTypeConfiguration<DataDictionary>
    {
        public DataDictionaryMap()
        {
            ToTable("DataDictionary");
            HasKey(t => t.Id);

            Property(t => t.DictionaryName).IsRequired().HasMaxLength(50).IsConcurrencyToken();
            HasMany(t => t.DataDictionaryInfos).WithRequired(s => s.DataDictionary).HasForeignKey(k => k.DataDictionaryId).WillCascadeOnDelete(false);
        }
    }
}
