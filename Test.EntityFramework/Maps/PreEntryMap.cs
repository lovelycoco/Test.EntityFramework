﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework.Maps
{
    public class PreEntryMap : EntityTypeConfiguration<PreEntry>
    {
        public PreEntryMap()
        {
            ToTable("PreEntry");
            HasKey(t => t.Id);
        }
    }
}
