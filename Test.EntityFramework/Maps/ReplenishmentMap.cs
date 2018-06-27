using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class ReplenishmentMap : EntityTypeConfiguration<Replenishment>
    {
        public ReplenishmentMap()
        {
            ToTable("Replenishment");
            HasKey(t => t.Id);

            HasRequired(t => t.ReplenishmentStatus).WithMany(d => d.ReplenishmentStatuses).HasForeignKey(t => t.ReplenishmentStatusId).WillCascadeOnDelete(false);
            HasMany(t => t.ReplenishmentLists).WithRequired(b => b.Replenishment).HasForeignKey(b => b.ReplenishmentId).WillCascadeOnDelete(false);
        }
    }
}
