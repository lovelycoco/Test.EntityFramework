﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class TagMap : EntityTypeConfiguration<Tag>
    {
        public TagMap()
        {
            ToTable("Tag");
            HasKey(t => t.Id);

            Property(t => t.TagCode).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.TagMemo).IsRequired().HasMaxLength(256).IsConcurrencyToken();
            Property(t => t.IsEnabled).IsConcurrencyToken();

            HasRequired(t => t.TagType).WithMany(d => d.Tags).HasForeignKey(t => t.DataDictionaryInfoId).WillCascadeOnDelete(false);
        }
    }
}
