namespace Test.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyEntity : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.RolePermissions", newName: "RolePermission");
            CreateTable(
                "dbo.UserRoleMap",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            AlterColumn("dbo.Permission", "PermissionName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Permission", "FeatureName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Permission", "Description", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoleMap", "RoleId", "dbo.Role");
            DropIndex("dbo.UserRoleMap", new[] { "RoleId" });
            AlterColumn("dbo.Permission", "Description", c => c.String());
            AlterColumn("dbo.Permission", "FeatureName", c => c.String());
            AlterColumn("dbo.Permission", "PermissionName", c => c.String());
            DropTable("dbo.UserRoleMap");
            RenameTable(name: "dbo.RolePermission", newName: "RolePermissions");
        }
    }
}
