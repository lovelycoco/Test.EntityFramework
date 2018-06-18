namespace Test.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyEntity1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserRoleMap", newName: "UserRole");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserRole", newName: "UserRoleMap");
        }
    }
}
