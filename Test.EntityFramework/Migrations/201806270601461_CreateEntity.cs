namespace Test.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        OpeningBalance = c.Int(nullable: false),
                        NormalQuantity = c.Int(nullable: false),
                        StorageQuantity = c.Int(nullable: false),
                        PCQuantity = c.Int(nullable: false),
                        BadGoodsQuantity = c.Int(nullable: false),
                        PreEntryQuantity = c.Int(nullable: false),
                        VirtualQuantity = c.Int(nullable: false),
                        BlockedQuantity = c.Int(nullable: false),
                        BlockedDate = c.DateTime(),
                        IsSearched = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaterialName = c.String(nullable: false, maxLength: 50),
                        PackageQuantity = c.Int(nullable: false),
                        Max = c.Int(nullable: false),
                        Min = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        PriorityLevel = c.Int(nullable: false),
                        SupplierId = c.Guid(nullable: false),
                        MaterialTypeId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        StorageBinId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.MaterialTypeId)
                .ForeignKey("dbo.StorageBin", t => t.StorageBinId)
                .ForeignKey("dbo.Supplier", t => t.SupplierId)
                .Index(t => t.SupplierId)
                .Index(t => t.MaterialTypeId)
                .Index(t => t.StorageBinId);
            
            CreateTable(
                "dbo.BadGoods",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TotalQuantity = c.Int(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        MaterialId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.BadGoodsList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        RepairNo = c.String(maxLength: 100),
                        RepairImage = c.Binary(storeType: "image"),
                        OperationTypeId = c.Guid(nullable: false),
                        OperationDate = c.DateTime(nullable: false),
                        BoxId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Box", t => t.BoxId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.OperationTypeId)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.MaterialId)
                .Index(t => t.OperationTypeId)
                .Index(t => t.BoxId);
            
            CreateTable(
                "dbo.Box",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BoxNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        BoxTypeId = c.Guid(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        IsDamaged = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.BoxTypeId)
                .Index(t => t.BoxTypeId);
            
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
                "dbo.BusinessLog",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BusinessTypeId = c.Guid(nullable: false),
                        OperationCodeId = c.Guid(nullable: false),
                        Memo = c.String(maxLength: 256),
                        OperationTable = c.String(nullable: false, maxLength: 50, unicode: false),
                        DataId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.BusinessTypeId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.OperationCodeId)
                .Index(t => t.BusinessTypeId)
                .Index(t => t.OperationCodeId);
            
            CreateTable(
                "dbo.BusinessLogList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BusinessLogId = c.Guid(nullable: false),
                        ModifiedField = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifiedFieldName = c.String(nullable: false, maxLength: 50),
                        OriginalValue = c.String(nullable: false, maxLength: 256),
                        TargetValue = c.String(nullable: false, maxLength: 256),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessLog", t => t.BusinessLogId)
                .Index(t => t.BusinessLogId);
            
            CreateTable(
                "dbo.CycleCount",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OperationDate = c.DateTime(nullable: false),
                        CountTypeId = c.Guid(nullable: false),
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
                .ForeignKey("dbo.DataDictionaryInfo", t => t.CountTypeId)
                .ForeignKey("dbo.StorageBin", t => t.StorageBinId)
                .Index(t => t.CountTypeId)
                .Index(t => t.StorageBinId);
            
            CreateTable(
                "dbo.CycleCountList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CycleCountId = c.Guid(nullable: false),
                        BoxId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Box", t => t.BoxId)
                .ForeignKey("dbo.CycleCount", t => t.CycleCountId)
                .Index(t => t.CycleCountId)
                .Index(t => t.BoxId);
            
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
                        Tag = c.String(nullable: false, maxLength: 50),
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
                        IsEnabled = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
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
                        LoginName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(maxLength: 256, unicode: false),
                        Password = c.String(nullable: false, maxLength: 100, unicode: false),
                        LastLoginTime = c.DateTime(),
                        IsEnabled = c.Boolean(nullable: false),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(maxLength: 13, unicode: false),
                        Sex = c.Int(nullable: false),
                        HeadPortrait = c.Binary(storeType: "image"),
                        IDCard = c.String(maxLength: 18, unicode: false),
                        HireDate = c.DateTime(),
                        IsQuited = c.Boolean(nullable: false),
                        QuitDate = c.DateTime(),
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
                        IsEnabled = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
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
                        IsEnabled = c.Boolean(nullable: false),
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
                        IsEnabled = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
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
                        IsEnabled = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PermissionMenuList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PermissionId = c.Guid(nullable: false),
                        MenuListId = c.Guid(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuList", t => t.MenuListId)
                .ForeignKey("dbo.Permission", t => t.PermissionId)
                .Index(t => t.PermissionId)
                .Index(t => t.MenuListId);
            
            CreateTable(
                "dbo.MenuList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MenuName = c.String(nullable: false, maxLength: 50, unicode: false),
                        DisplayName = c.String(nullable: false, maxLength: 50),
                        MenuURL = c.String(nullable: false, maxLength: 256),
                        MenuDescription = c.String(nullable: false, maxLength: 50),
                        MenuIcon = c.Binary(nullable: false, storeType: "image"),
                        IsEnabled = c.Boolean(nullable: false),
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
                "dbo.MaterialList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BillOfMaterialId = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        BatchId = c.Guid(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        MaterialStatusId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        BoxId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Batch", t => t.BatchId)
                .ForeignKey("dbo.BillofMaterial", t => t.BillOfMaterialId)
                .ForeignKey("dbo.Box", t => t.BoxId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.MaterialStatusId)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.BillOfMaterialId)
                .Index(t => t.MaterialId)
                .Index(t => t.BatchId)
                .Index(t => t.MaterialStatusId)
                .Index(t => t.BoxId);
            
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
                "dbo.BillofMaterial",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BillNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Memo = c.String(maxLength: 256),
                        ReceiveDate = c.DateTime(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trace",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialListId = c.Guid(nullable: false),
                        TraceStatusId = c.Guid(nullable: false),
                        Operation = c.String(maxLength: 50),
                        Memo = c.String(maxLength: 256),
                        CurrentQuantity = c.Int(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.TraceStatusId)
                .ForeignKey("dbo.MaterialList", t => t.MaterialListId)
                .Index(t => t.MaterialListId)
                .Index(t => t.TraceStatusId);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NoteNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        NoteTypeId = c.Guid(nullable: false),
                        NoteStatusId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.NoteStatusId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.NoteTypeId)
                .Index(t => t.NoteTypeId)
                .Index(t => t.NoteStatusId);
            
            CreateTable(
                "dbo.NoteList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NoteId = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        TotalQuantity = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Note", t => t.NoteId)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.NoteId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.Pickup",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PickupNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        IsPrinted = c.Boolean(nullable: false),
                        PrintDate = c.DateTime(),
                        PickupTypeId = c.Guid(nullable: false),
                        PickupStatusId = c.Guid(nullable: false),
                        PickupUserId = c.Guid(),
                        PickupDate = c.DateTime(),
                        PickupAreaId = c.Guid(nullable: false),
                        OutCardUserId = c.Guid(),
                        OutCardDate = c.DateTime(),
                        IsOutCardPrinted = c.Boolean(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        NodeId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.PickupAreaId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.PickupStatusId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.PickupTypeId)
                .ForeignKey("dbo.Note", t => t.NodeId)
                .Index(t => t.PickupTypeId)
                .Index(t => t.PickupStatusId)
                .Index(t => t.PickupAreaId)
                .Index(t => t.NodeId);
            
            CreateTable(
                "dbo.PickupList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PickingListId = c.Guid(nullable: false),
                        BoxId = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Box", t => t.BoxId)
                .ForeignKey("dbo.Pickup", t => t.PickingListId)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.MaterialId)
                .Index(t => t.PickingListId)
                .Index(t => t.BoxId);
            
            CreateTable(
                "dbo.OperatorLog",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BusinessTypeId = c.Guid(nullable: false),
                        OperationCodeId = c.Guid(nullable: false),
                        Operation = c.String(nullable: false, maxLength: 50),
                        LevelId = c.Guid(nullable: false),
                        Memo = c.String(nullable: false, maxLength: 256),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.BusinessTypeId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.LevelId)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.OperationCodeId)
                .Index(t => t.BusinessTypeId)
                .Index(t => t.OperationCodeId)
                .Index(t => t.LevelId);
            
            CreateTable(
                "dbo.SelfPickup",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SelfPeople = c.String(nullable: false, maxLength: 10),
                        SelfDate = c.DateTime(nullable: false),
                        SupplierId = c.Guid(nullable: false),
                        IsPrinted = c.Boolean(nullable: false),
                        PrintDate = c.DateTime(),
                        OriginalTypeId = c.Guid(nullable: false),
                        OutCardUserId = c.Guid(),
                        OutCardDate = c.DateTime(),
                        IsOutCardPrinted = c.Boolean(nullable: false),
                        Memo = c.String(maxLength: 256),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.OriginalTypeId)
                .ForeignKey("dbo.Supplier", t => t.SupplierId)
                .Index(t => t.SupplierId)
                .Index(t => t.OriginalTypeId);
            
            CreateTable(
                "dbo.SelfPickupList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SelfId = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SelfPickup", t => t.SelfId)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.SelfId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierName = c.String(nullable: false, maxLength: 50),
                        SupplierCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        SupplierDescription = c.String(nullable: false, maxLength: 50),
                        SupplierAddress = c.String(nullable: false, maxLength: 256),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Replenishment",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ReplenishmentDate = c.DateTime(nullable: false),
                        ReplenishmentStatusId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.ReplenishmentStatusId)
                .Index(t => t.ReplenishmentStatusId);
            
            CreateTable(
                "dbo.ReplenishmentList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ReplenishmentId = c.Guid(nullable: false),
                        BoxId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Box", t => t.BoxId)
                .ForeignKey("dbo.Replenishment", t => t.ReplenishmentId)
                .Index(t => t.ReplenishmentId)
                .Index(t => t.BoxId);
            
            CreateTable(
                "dbo.PickupTemplate",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TemplateName = c.String(nullable: false, maxLength: 256),
                        TemplateTypeId = c.Guid(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataDictionaryInfo", t => t.TemplateTypeId)
                .Index(t => t.TemplateTypeId);
            
            CreateTable(
                "dbo.TemplateList",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TemplateId = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        TotalQuantity = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PickupTemplate", t => t.TemplateId)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.TemplateId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.PreEntry",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TotalQuantity = c.Int(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        MaterialId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        OpeningBalance = c.Int(nullable: false),
                        NormalQuantity = c.Int(nullable: false),
                        StorageQuantity = c.Int(nullable: false),
                        PCQuantity = c.Int(nullable: false),
                        BadGoodsQuantity = c.Int(nullable: false),
                        PreEntryQuantity = c.Int(nullable: false),
                        VirtualQuantity = c.Int(nullable: false),
                        Operator = c.Guid(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Material", t => t.MaterialId)
                .Index(t => t.MaterialId);
            
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
            DropForeignKey("dbo.UnitPrice", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.TemplateList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.Material", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Material", "StorageBinId", "dbo.StorageBin");
            DropForeignKey("dbo.Stock", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.SelfPickupList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.PreEntry", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.PickupList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.NoteList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.Material", "MaterialTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.MaterialList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.BadGoodsList", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.BadGoodsList", "OperationTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.BadGoodsList", "BoxId", "dbo.Box");
            DropForeignKey("dbo.Box", "BoxTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.PickupTemplate", "TemplateTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.TemplateList", "TemplateId", "dbo.PickupTemplate");
            DropForeignKey("dbo.Replenishment", "ReplenishmentStatusId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.ReplenishmentList", "ReplenishmentId", "dbo.Replenishment");
            DropForeignKey("dbo.ReplenishmentList", "BoxId", "dbo.Box");
            DropForeignKey("dbo.SelfPickup", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.SelfPickupList", "SelfId", "dbo.SelfPickup");
            DropForeignKey("dbo.SelfPickup", "OriginalTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.OperatorLog", "OperationCodeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.OperatorLog", "LevelId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.OperatorLog", "BusinessTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.Pickup", "NodeId", "dbo.Note");
            DropForeignKey("dbo.Pickup", "PickupTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.Pickup", "PickupStatusId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.PickupList", "PickingListId", "dbo.Pickup");
            DropForeignKey("dbo.PickupList", "BoxId", "dbo.Box");
            DropForeignKey("dbo.Pickup", "PickupAreaId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.Note", "NoteTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.Note", "NoteStatusId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.NoteList", "NoteId", "dbo.Note");
            DropForeignKey("dbo.Trace", "MaterialListId", "dbo.MaterialList");
            DropForeignKey("dbo.Trace", "TraceStatusId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.MaterialList", "MaterialStatusId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.MaterialList", "BoxId", "dbo.Box");
            DropForeignKey("dbo.MaterialList", "BillOfMaterialId", "dbo.BillofMaterial");
            DropForeignKey("dbo.MaterialList", "BatchId", "dbo.Batch");
            DropForeignKey("dbo.DataDictionaryInfo", "DataDictionaryId", "dbo.DataDictionary");
            DropForeignKey("dbo.CycleCount", "StorageBinId", "dbo.StorageBin");
            DropForeignKey("dbo.UserStorageBin", "StorageBinId", "dbo.StorageBin");
            DropForeignKey("dbo.UserStorageBin", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.RolePermission", "RoleId", "dbo.Role");
            DropForeignKey("dbo.RolePermission", "PermissionId", "dbo.Permission");
            DropForeignKey("dbo.PermissionMenuList", "PermissionId", "dbo.Permission");
            DropForeignKey("dbo.PermissionMenuList", "MenuListId", "dbo.MenuList");
            DropForeignKey("dbo.StorageBin", "StorageAreaId", "dbo.StorageArea");
            DropForeignKey("dbo.CycleCountList", "CycleCountId", "dbo.CycleCount");
            DropForeignKey("dbo.CycleCountList", "BoxId", "dbo.Box");
            DropForeignKey("dbo.CycleCount", "CountTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.BusinessLog", "OperationCodeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.BusinessLog", "BusinessTypeId", "dbo.DataDictionaryInfo");
            DropForeignKey("dbo.BusinessLogList", "BusinessLogId", "dbo.BusinessLog");
            DropForeignKey("dbo.BadGoods", "MaterialId", "dbo.Material");
            DropForeignKey("dbo.Accounts", "MaterialId", "dbo.Material");
            DropIndex("dbo.UnitPrice", new[] { "MaterialId" });
            DropIndex("dbo.Stock", new[] { "MaterialId" });
            DropIndex("dbo.PreEntry", new[] { "MaterialId" });
            DropIndex("dbo.TemplateList", new[] { "MaterialId" });
            DropIndex("dbo.TemplateList", new[] { "TemplateId" });
            DropIndex("dbo.PickupTemplate", new[] { "TemplateTypeId" });
            DropIndex("dbo.ReplenishmentList", new[] { "BoxId" });
            DropIndex("dbo.ReplenishmentList", new[] { "ReplenishmentId" });
            DropIndex("dbo.Replenishment", new[] { "ReplenishmentStatusId" });
            DropIndex("dbo.SelfPickupList", new[] { "MaterialId" });
            DropIndex("dbo.SelfPickupList", new[] { "SelfId" });
            DropIndex("dbo.SelfPickup", new[] { "OriginalTypeId" });
            DropIndex("dbo.SelfPickup", new[] { "SupplierId" });
            DropIndex("dbo.OperatorLog", new[] { "LevelId" });
            DropIndex("dbo.OperatorLog", new[] { "OperationCodeId" });
            DropIndex("dbo.OperatorLog", new[] { "BusinessTypeId" });
            DropIndex("dbo.PickupList", new[] { "BoxId" });
            DropIndex("dbo.PickupList", new[] { "PickingListId" });
            DropIndex("dbo.PickupList", new[] { "MaterialId" });
            DropIndex("dbo.Pickup", new[] { "NodeId" });
            DropIndex("dbo.Pickup", new[] { "PickupAreaId" });
            DropIndex("dbo.Pickup", new[] { "PickupStatusId" });
            DropIndex("dbo.Pickup", new[] { "PickupTypeId" });
            DropIndex("dbo.NoteList", new[] { "MaterialId" });
            DropIndex("dbo.NoteList", new[] { "NoteId" });
            DropIndex("dbo.Note", new[] { "NoteStatusId" });
            DropIndex("dbo.Note", new[] { "NoteTypeId" });
            DropIndex("dbo.Trace", new[] { "TraceStatusId" });
            DropIndex("dbo.Trace", new[] { "MaterialListId" });
            DropIndex("dbo.MaterialList", new[] { "BoxId" });
            DropIndex("dbo.MaterialList", new[] { "MaterialStatusId" });
            DropIndex("dbo.MaterialList", new[] { "BatchId" });
            DropIndex("dbo.MaterialList", new[] { "MaterialId" });
            DropIndex("dbo.MaterialList", new[] { "BillOfMaterialId" });
            DropIndex("dbo.PermissionMenuList", new[] { "MenuListId" });
            DropIndex("dbo.PermissionMenuList", new[] { "PermissionId" });
            DropIndex("dbo.RolePermission", new[] { "PermissionId" });
            DropIndex("dbo.RolePermission", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.UserStorageBin", new[] { "StorageBinId" });
            DropIndex("dbo.UserStorageBin", new[] { "UserId" });
            DropIndex("dbo.StorageBin", new[] { "StorageAreaId" });
            DropIndex("dbo.CycleCountList", new[] { "BoxId" });
            DropIndex("dbo.CycleCountList", new[] { "CycleCountId" });
            DropIndex("dbo.CycleCount", new[] { "StorageBinId" });
            DropIndex("dbo.CycleCount", new[] { "CountTypeId" });
            DropIndex("dbo.BusinessLogList", new[] { "BusinessLogId" });
            DropIndex("dbo.BusinessLog", new[] { "OperationCodeId" });
            DropIndex("dbo.BusinessLog", new[] { "BusinessTypeId" });
            DropIndex("dbo.DataDictionaryInfo", new[] { "DataDictionaryId" });
            DropIndex("dbo.Box", new[] { "BoxTypeId" });
            DropIndex("dbo.BadGoodsList", new[] { "BoxId" });
            DropIndex("dbo.BadGoodsList", new[] { "OperationTypeId" });
            DropIndex("dbo.BadGoodsList", new[] { "MaterialId" });
            DropIndex("dbo.BadGoods", new[] { "MaterialId" });
            DropIndex("dbo.Material", new[] { "StorageBinId" });
            DropIndex("dbo.Material", new[] { "MaterialTypeId" });
            DropIndex("dbo.Material", new[] { "SupplierId" });
            DropIndex("dbo.Accounts", new[] { "MaterialId" });
            DropTable("dbo.UnitPrice");
            DropTable("dbo.Stock");
            DropTable("dbo.PreEntry");
            DropTable("dbo.TemplateList");
            DropTable("dbo.PickupTemplate");
            DropTable("dbo.ReplenishmentList");
            DropTable("dbo.Replenishment");
            DropTable("dbo.Supplier");
            DropTable("dbo.SelfPickupList");
            DropTable("dbo.SelfPickup");
            DropTable("dbo.OperatorLog");
            DropTable("dbo.PickupList");
            DropTable("dbo.Pickup");
            DropTable("dbo.NoteList");
            DropTable("dbo.Note");
            DropTable("dbo.Trace");
            DropTable("dbo.BillofMaterial");
            DropTable("dbo.Batch");
            DropTable("dbo.MaterialList");
            DropTable("dbo.DataDictionary");
            DropTable("dbo.MenuList");
            DropTable("dbo.PermissionMenuList");
            DropTable("dbo.Permission");
            DropTable("dbo.RolePermission");
            DropTable("dbo.Role");
            DropTable("dbo.UserRole");
            DropTable("dbo.User");
            DropTable("dbo.UserStorageBin");
            DropTable("dbo.StorageArea");
            DropTable("dbo.StorageBin");
            DropTable("dbo.CycleCountList");
            DropTable("dbo.CycleCount");
            DropTable("dbo.BusinessLogList");
            DropTable("dbo.BusinessLog");
            DropTable("dbo.DataDictionaryInfo");
            DropTable("dbo.Box");
            DropTable("dbo.BadGoodsList");
            DropTable("dbo.BadGoods");
            DropTable("dbo.Material");
            DropTable("dbo.Accounts");
        }
    }
}
