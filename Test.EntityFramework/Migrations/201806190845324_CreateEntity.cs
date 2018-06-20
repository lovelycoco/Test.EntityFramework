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
                "dbo.Material",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaterialName = c.String(nullable: false, maxLength: 50),
                        PackageNumber = c.Int(nullable: false),
                        HighStorage = c.Int(nullable: false),
                        LowStorage = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        PriorityLevel = c.Int(nullable: false),
                        SupplierId = c.Guid(nullable: false),
                        StorageLocationId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        StorageLocation_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StorageLocation", t => t.StorageLocation_Id)
                .ForeignKey("dbo.Supplier", t => t.SupplierId)
                .Index(t => t.SupplierId)
                .Index(t => t.StorageLocation_Id);
            
            CreateTable(
                "dbo.StorageLocation",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LocationCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        LocationName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        LocationType = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        StorageAreaId = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StorageArea", t => t.StorageAreaId)
                .Index(t => t.StorageAreaId);
            
            CreateTable(
                "dbo.StorageArea",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AreaCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        AreaName = c.String(nullable: false, maxLength: 50),
                        AreaType = c.Int(nullable: false),
                        Description = c.String(maxLength: 255),
                        IsEnabled = c.Boolean(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserStorageLocation",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        SotrageLocationId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.StorageLocation", t => t.SotrageLocationId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.SotrageLocationId);
            
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
            
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PermissionName = c.String(nullable: false, maxLength: 50),
                        FeatureName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 255),
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
                "dbo.RolePermission",
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
                "dbo.Student",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        CourseId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Level = c.Int(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        StudentId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Student_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.UserRole",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Courses", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.RolePermission", "RoleId", "dbo.Role");
            DropForeignKey("dbo.RolePermission", "PermissionId", "dbo.Permission");
            DropForeignKey("dbo.Material", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Material", "StorageLocation_Id", "dbo.StorageLocation");
            DropForeignKey("dbo.UserStorageLocation", "SotrageLocationId", "dbo.StorageLocation");
            DropForeignKey("dbo.UserStorageLocation", "UserId", "dbo.User");
            DropForeignKey("dbo.StorageLocation", "StorageAreaId", "dbo.StorageArea");
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.Courses", new[] { "Student_Id" });
            DropIndex("dbo.RolePermission", new[] { "PermissionId" });
            DropIndex("dbo.RolePermission", new[] { "RoleId" });
            DropIndex("dbo.UserStorageLocation", new[] { "SotrageLocationId" });
            DropIndex("dbo.UserStorageLocation", new[] { "UserId" });
            DropIndex("dbo.StorageLocation", new[] { "StorageAreaId" });
            DropIndex("dbo.Material", new[] { "StorageLocation_Id" });
            DropIndex("dbo.Material", new[] { "SupplierId" });
            DropTable("dbo.UserRole");
            DropTable("dbo.Courses");
            DropTable("dbo.Student");
            DropTable("dbo.RolePermission");
            DropTable("dbo.Role");
            DropTable("dbo.Permission");
            DropTable("dbo.Supplier");
            DropTable("dbo.UserStorageLocation");
            DropTable("dbo.StorageArea");
            DropTable("dbo.StorageLocation");
            DropTable("dbo.Material");
            DropTable("dbo.User");
        }
    }
}
