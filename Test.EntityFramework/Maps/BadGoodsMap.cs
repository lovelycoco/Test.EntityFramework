using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class BadGoodsMap : EntityTypeConfiguration<BadGoods>
    {
        public BadGoodsMap()
        {
            ToTable("BadGoods");
            HasKey(t => t.Id);
            HasMany(t => t.BadGoodsLists).WithRequired(b=>b.BadGoods).HasForeignKey(b=>b.BadGoodsId).WillCascadeOnDelete(false);
        }
    }
}
