namespace Test.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batch",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BatchNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductionDate = c.DateTime(),
                        IsBlocked = c.Boolean(nullable: false),
                        BlockedDate = c.DateTime(),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaterialList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BillOfMaterialId = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        BatchId = c.Guid(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DataDictionaryInfoId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BillofMaterial", t => t.BillOfMaterialId)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.DataDictionaryInfoId)
                .ForeignKey("dbo.Batch", t => t.BatchId)
                .Index(t => t.BillOfMaterialId)
                .Index(t => t.MaterialId)
                .Index(t => t.BatchId)
                .Index(t => t.DataDictionaryInfoId);
            
            CreateTable(
                "dbo.BillofMaterial",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BillNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Memo = c.String(),
                        ReceiveDate = c.DateTime(nullable: false),
                        Operator = c.Guid(nullable: false),
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
                        MaterialNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaterialName = c.String(nullable: false, maxLength: 50),
                        PackageNum = c.Int(nullable: false),
                        Max = c.Int(nullable: false),
                        Min = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        PriorityLevel = c.Int(nullable: false),
                        SupplierId = c.Guid(nullable: false),
                        DataDictionaryInfoId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        StorageBinId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.DataDictionaryInfoId)
                .ForeignKey("dbo.StorageBin", t => t.StorageBinId)
                .ForeignKey("dbo.Supplier", t => t.SupplierId)
                .Index(t => t.SupplierId)
                .Index(t => t.DataDictionaryInfoId)
                .Index(t => t.StorageBinId);
            
            CreateTable(
                "dbo.DataDictionaryInfo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DictionaryCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        DictionaryDescription = c.String(nullable: false, maxLength: 256),
                        DataDictionaryId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionary", t => t.DataDictionaryId)
                .Index(t => t.DataDictionaryId);
            
            CreateTable(
                "dbo.CycleCount",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DataDictionaryInfoId = c.Guid(nullable: false),
                        StorageBinId = c.Guid(nullable: false),
                        TotalQuantity = c.Int(nullable: false),
                        LostQuantity = c.Int(nullable: false),
                        Memo = c.String(maxLength: 256),
                        IsVisual = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.DataDictionaryInfoId)
                .ForeignKey("dbo.StorageBin", t => t.StorageBinId)
                .Index(t => t.DataDictionaryInfoId)
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
                        AreaDescription = c.String(maxLength: 256),
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
                .ForeignKey("dbo.User", t => t.UserId)
                .ForeignKey("dbo.StorageBin", t => t.StorageBinId)
                .Index(t => t.UserId)
                .Index(t => t.StorageBinId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        NormalizedUserName = c.String(nullable: false, maxLength: 256),
                        Email = c.String(maxLength: 256, unicode: false),
                        Password = c.String(nullable: false, maxLength: 256, unicode: false),
                        LastLoginTime = c.DateTime(),
                        LastLogoutTime = c.DateTime(),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .ForeignKey("dbo.Role", t => t.RoleId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
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
                .ForeignKey("dbo.Permission", t => t.PermissionId)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PermissionName = c.String(nullable: false, maxLength: 50),
                        FeatureName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 256),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DataDictionary",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DictionaryName = c.String(nullable: false, maxLength: 50),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pickup",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PickupNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        IsPrinted = c.Boolean(nullable: false),
                        PrintDate = c.DateTime(),
                        DataDictionaryInfoId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        PickupType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.DataDictionaryInfoId)
                .Index(t => t.DataDictionaryInfoId);
            
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
                .ForeignKey("dbo.Pickup", t => t.PickingListId)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.MaterialId)
                .Index(t => t.PickingListId);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TagCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DataDictionaryInfoId = c.Guid(nullable: false),
                        TagMemo = c.String(nullable: false, maxLength: 256),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.DataDictionaryInfoId)
                .Index(t => t.DataDictionaryInfoId);
            
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
                "dbo.UnitPrice",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        MaterialId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.MaterialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialList", "BatchId", "dbo.Batch");
            DropForeignKey("dbo.MaterialList", "DataDictionaryInfoId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.UnitPrice", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.Material", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Material", "StorageBinId", "dbo.StorageBin");
            DropForeignKey("dbo.PickupList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.MaterialList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.Material", "DataDictionaryInfoId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.Tag", "DataDictionaryInfoId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.Pickup", "DataDictionaryInfoId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.PickupList", "PickingListId", "dbo.Pickup");
            DropForeignKey("dbo.DataDictionaryInfo", "DataDictionaryId", "dbo.DataDictionary");
            DropForeignKey("dbo.CycleCount", "StorageBinId", "dbo.StorageBin");
            DropForeignKey("dbo.UserStorageBin", "StorageBinId", "dbo.StorageBin");
            DropForeignKey("dbo.UserStorageBin", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.RolePermission", "RoleId", "dbo.Role");
            DropForeignKey("dbo.RolePermission", "PermissionId", "dbo.Permission");
            DropForeignKey("dbo.StorageBin", "StorageAreaId", "dbo.StorageArea");
            DropForeignKey("dbo.CycleCount", "DataDictionaryInfoId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.MaterialList", "BillOfMaterialId", "dbo.BillofMaterial");
            DropIndex("dbo.UnitPrice", new[] { "MaterialId" });
            DropIndex("dbo.Tag", new[] { "DataDictionaryInfoId" });
            DropIndex("dbo.PickupList", new[] { "PickingListId" });
            DropIndex("dbo.PickupList", new[] { "MaterialId" });
            DropIndex("dbo.Pickup", new[] { "DataDictionaryInfoId" });
            DropIndex("dbo.RolePermission", new[] { "PermissionId" });
            DropIndex("dbo.RolePermission", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.UserStorageBin", new[] { "StorageBinId" });
            DropIndex("dbo.UserStorageBin", new[] { "UserId" });
            DropIndex("dbo.StorageBin", new[] { "StorageAreaId" });
            DropIndex("dbo.CycleCount", new[] { "StorageBinId" });
            DropIndex("dbo.CycleCount", new[] { "DataDictionaryInfoId" });
            DropIndex("dbo.DataDictionaryInfo", new[] { "DataDictionaryId" });
            DropIndex("dbo.Material", new[] { "StorageBinId" });
            DropIndex("dbo.Material", new[] { "DataDictionaryInfoId" });
            DropIndex("dbo.Material", new[] { "SupplierId" });
            DropIndex("dbo.MaterialList", new[] { "DataDictionaryInfoId" });
            DropIndex("dbo.MaterialList", new[] { "BatchId" });
            DropIndex("dbo.MaterialList", new[] { "MaterialId" });
            DropIndex("dbo.MaterialList", new[] { "BillOfMaterialId" });
            DropTable("dbo.UnitPrice");
            DropTable("dbo.Supplier");
            DropTable("dbo.Tag");
            DropTable("dbo.PickupList");
            DropTable("dbo.Pickup");
            DropTable("dbo.DataDictionary");
            DropTable("dbo.Permission");
            DropTable("dbo.RolePermission");
            DropTable("dbo.Role");
            DropTable("dbo.UserRole");
            DropTable("dbo.User");
            DropTable("dbo.UserStorageBin");
            DropTable("dbo.StorageArea");
            DropTable("dbo.StorageBin");
            DropTable("dbo.CycleCount");
            DropTable("dbo.DataDictionaryInfo");
            DropTable("dbo.Material");
            DropTable("dbo.BillofMaterial");
            DropTable("dbo.MaterialList");
            DropTable("dbo.Batch");
        }
    }
}
