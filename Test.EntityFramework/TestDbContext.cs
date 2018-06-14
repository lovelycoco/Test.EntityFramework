using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;

namespace Test.EntityFramework
{
    public class TestDbContext : DbContext
    {

        public IDbSet<Student> Students { get; set; }

        public TestDbContext() : base("name=Default")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TestDbContext>());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
