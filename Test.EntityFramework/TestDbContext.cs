using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;
using Test.Core.Entities.Test;

namespace Test.EntityFramework
{
    public class TestDbContext : DbContext
    {

        public IDbSet<Student> Students { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<Permission> Permissions { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }
        public IDbSet<RolePermission> RolePermissions { get; set; }

        public TestDbContext() : base("name=Default")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TestDbContext>());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !(string.IsNullOrEmpty(type.Namespace))).Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }



            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
