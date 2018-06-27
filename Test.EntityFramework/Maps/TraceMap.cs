using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class TraceMap : EntityTypeConfiguration<Trace>
    {
        public TraceMap()
        {
            ToTable("Trace");
            HasKey(t => t.Id);
            Property(t => t.Operation).IsOptional().HasMaxLength(50).IsConcurrencyToken();
            Property(t => t.Memo).IsOptional().HasMaxLength(256).IsConcurrencyToken();

            HasRequired(t => t.TraceStatus).WithMany(d => d.TraceStatuses).HasForeignKey(t => t.TraceStatusId).WillCascadeOnDelete(false);
        }
    }
}
