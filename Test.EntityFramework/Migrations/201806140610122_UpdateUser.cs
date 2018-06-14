namespace Test.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "UserName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.User", "NormalizedUserName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false, maxLength: 255, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Password", c => c.String());
            AlterColumn("dbo.User", "NormalizedUserName", c => c.String());
            AlterColumn("dbo.User", "UserName", c => c.String());
        }
    }
}
