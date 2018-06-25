using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class NoteMap : EntityTypeConfiguration<Note>
    {
        public NoteMap()
        {
            ToTable("Note");
            HasKey(t => t.Id);

            Property(t => t.NoteNo).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsConcurrencyToken();
            HasMany(t => t.NoteLists).WithRequired(n => n.Note).HasForeignKey(n => n.NoteId).WillCascadeOnDelete(false);
            HasRequired(t => t.NoteType).WithMany(d => d.NoteTypes).HasForeignKey(t => t.TypeId).WillCascadeOnDelete(false);
            HasRequired(t => t.NoteStatus).WithMany(d => d.NoteStatuses).HasForeignKey(t => t.StatusId).WillCascadeOnDelete(false);
            HasOptional(t => t.Pickup).WithOptionalPrincipal(p => p.Note).Map(x => x.MapKey("NodeId")).WillCascadeOnDelete(false);
        }
    }
}
