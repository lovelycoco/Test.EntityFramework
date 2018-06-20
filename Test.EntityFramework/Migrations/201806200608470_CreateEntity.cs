namespace Test.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaterialName = c.String(nullable: false, maxLength: 50),
                        PackageNum = c.Int(nullable: false),
                        HighStorage = c.Int(nullable: false),
                        LowStorage = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        PriorityLevel = c.Int(nullable: false),
                        SupplierId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        StorageBinId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StorageBin", t => t.StorageBinId)
                .ForeignKey("dbo.Supplier", t => t.SupplierId)
                .Index(t => t.SupplierId)
                .Index(t => t.StorageBinId);
            
            CreateTable(
                "dbo.StorageBin",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BinCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        BinName = c.String(nullable: false, maxLength: 50),
                        BinDescription = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        StorageAreaId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        BinType = c.Int(),
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
                        AreaDescription = c.String(maxLength: 255),
                        IsEnabled = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        AreaType = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserStorageBin",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        StorageBinId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.StorageBin", t => t.StorageBinId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.StorageBinId);
            
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
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierName = c.String(nullable: false, maxLength: 50),
                        SupplierCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        Operator = c.Guid(nullable: false),
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
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickupList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        MaterialNum = c.Int(nullable: false),
                        PickingListId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Material", t => t.MaterialId, cascadeDelete: true)
                .ForeignKey("dbo.Pickup", t => t.PickingListId)
                .Index(t => t.MaterialId)
                .Index(t => t.PickingListId);
            
            CreateTable(
                "dbo.Pickup",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PickupNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        IsPrinted = c.Boolean(nullable: false),
                        PrintTime = c.DateTime(),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        PickupType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleName = c.String(nullable: false, maxLength: 50),
                        Operator = c.Guid(nullable: false),
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
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.RolePermission", "RoleId", "dbo.Role");
            DropForeignKey("dbo.RolePermission", "PermissionId", "dbo.Permission");
            DropForeignKey("dbo.PickupList", "PickingListId", "dbo.Pickup");
            DropForeignKey("dbo.PickupList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.Material", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Material", "StorageBinId", "dbo.StorageBin");
            DropForeignKey("dbo.UserStorageBin", "StorageBinId", "dbo.StorageBin");
            DropForeignKey("dbo.UserStorageBin", "UserId", "dbo.User");
            DropForeignKey("dbo.StorageBin", "StorageAreaId", "dbo.StorageArea");
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.RolePermission", new[] { "PermissionId" });
            DropIndex("dbo.RolePermission", new[] { "RoleId" });
            DropIndex("dbo.PickupList", new[] { "PickingListId" });
            DropIndex("dbo.PickupList", new[] { "MaterialId" });
            DropIndex("dbo.UserStorageBin", new[] { "StorageBinId" });
            DropIndex("dbo.UserStorageBin", new[] { "UserId" });
            DropIndex("dbo.StorageBin", new[] { "StorageAreaId" });
            DropIndex("dbo.Material", new[] { "StorageBinId" });
            DropIndex("dbo.Material", new[] { "SupplierId" });
            DropTable("dbo.UserRole");
            DropTable("dbo.RolePermission");
            DropTable("dbo.Role");
            DropTable("dbo.Pickup");
            DropTable("dbo.PickupList");
            DropTable("dbo.Permission");
            DropTable("dbo.Supplier");
            DropTable("dbo.User");
            DropTable("dbo.UserStorageBin");
            DropTable("dbo.StorageArea");
            DropTable("dbo.StorageBin");
            DropTable("dbo.Material");
        }
    }
}
