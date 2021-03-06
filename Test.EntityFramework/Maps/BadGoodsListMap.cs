﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class BadGoodsListMap : EntityTypeConfiguration<BadGoodsList>
    {
        public BadGoodsListMap()
        {
            ToTable("BadGoodsList");
            HasKey(t => t.Id);

            Property(t => t.RepairNo).IsOptional().HasMaxLength(100).IsConcurrencyToken();
            Property(t => t.RepairImage).IsOptional().HasColumnType("image").IsConcurrencyToken();

            HasRequired(t => t.OperationType).WithMany(d => d.BadGoodsOperationTypes).HasForeignKey(t => t.OperationTypeId).WillCascadeOnDelete(false);
            HasOptional(t => t.Box).WithMany(b => b.BadGoodsLists).HasForeignKey(t=>t.BoxId).WillCascadeOnDelete(false);
        }
    }
}
