namespace Test.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Test.EntityFramework.Migrations.SeedData;

    internal sealed class Configuration : DbMigrationsConfiguration<Test.EntityFramework.TestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestDbContext context)
        {
            //Host seed
            new InitialHostDbBuilder(context).Create();
            context.SaveChanges();

            var updater = new DBDescriptionUpdater<TestDbContext>(context);
            updater.UpdateDatabaseDescriptions();
        }
    }
}
