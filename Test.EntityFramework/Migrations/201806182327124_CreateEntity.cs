namespace Test.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 255),
                        NormalizedUserName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(maxLength: 255, unicode: false),
                        Password = c.String(nullable: false, maxLength: 255, unicode: false),
                        LastLoginTime = c.DateTime(),
                        LastLogoutTime = c.DateTime(),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PermissionName = c.String(),
                        FeatureName = c.String(),
                        Description = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleName = c.String(nullable: false, maxLength: 50),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolePermissions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        PermissionId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permission", t => t.PermissionId, cascadeDelete: true)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierName = c.String(nullable: false, maxLength: 50),
                        SupplierCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePermissions", "RoleId", "dbo.Role");
            DropForeignKey("dbo.RolePermissions", "PermissionId", "dbo.Permission");
            DropIndex("dbo.RolePermissions", new[] { "PermissionId" });
            DropIndex("dbo.RolePermissions", new[] { "RoleId" });
            DropTable("dbo.Supplier");
            DropTable("dbo.RolePermissions");
            DropTable("dbo.Role");
            DropTable("dbo.Permission");
            DropTable("dbo.User");
        }
    }
}
