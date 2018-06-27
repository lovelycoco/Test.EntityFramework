using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class CycleCountListMap : EntityTypeConfiguration<CycleCountList>
    {
        public CycleCountListMap()
        {
            ToTable("CycleCountList");
            HasKey(t => t.Id);

            HasRequired(t => t.Box).WithMany(b => b.CycleCountLists).HasForeignKey(t => t.BoxId).WillCascadeOnDelete(false);
        }
    }
}
