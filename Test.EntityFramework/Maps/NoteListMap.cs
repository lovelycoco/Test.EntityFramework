using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class NoteListMap : EntityTypeConfiguration<NoteList>
    {
        public NoteListMap()
        {
            ToTable("NoteList");
            HasKey(t => t.Id);


        }
    }
}
