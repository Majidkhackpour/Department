namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerLogs",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CustomerGuid = c.Guid(nullable: false),
                        SideName = c.String(maxLength: 200),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 100),
                        NationalCode = c.String(maxLength: 20),
                        AppSerial = c.String(maxLength: 50),
                        Address = c.String(),
                        PostalCode = c.String(maxLength: 20),
                        Tell1 = c.String(maxLength: 15),
                        Tell2 = c.String(maxLength: 15),
                        Tell3 = c.String(maxLength: 15),
                        Tell4 = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        Description = c.String(),
                        ExpireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CustomerGuid = c.Guid(nullable: false),
                        UserGuid = c.Guid(nullable: false),
                        ContractCode = c.String(maxLength: 20),
                        Version = c.String(maxLength: 20),
                        LearningCount = c.Int(nullable: false),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        PrdGuid = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.PanelLineNumbers",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        PanelGuid = c.Guid(nullable: false),
                        LineNumber = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Name = c.String(maxLength: 200),
                        Code = c.String(maxLength: 20),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.Receptions",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CustomerGuid = c.Guid(nullable: false),
                        UserGuid = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.Short(nullable: false),
                        ResidNo = c.String(maxLength: 100),
                        PeygiriNo = c.String(maxLength: 100),
                        SafeBoxGuid = c.Guid(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.SafeBoxes",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Name = c.String(maxLength: 100),
                        Type = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.SmsLogs",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                        UserGuid = c.Guid(nullable: false),
                        Sender = c.String(maxLength: 100),
                        Reciver = c.String(maxLength: 100),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.SmsPanels",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        UserName = c.String(maxLength: 200),
                        Password = c.String(maxLength: 200),
                        Api = c.String(),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.UserLogs",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                        UserGuid = c.Guid(nullable: false),
                        Type = c.Short(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Guid);
            
            AddColumn("dbo.Users", "IsBlock", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Type", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Type");
            DropColumn("dbo.Users", "IsBlock");
            DropTable("dbo.UserLogs");
            DropTable("dbo.SmsPanels");
            DropTable("dbo.SmsLogs");
            DropTable("dbo.SafeBoxes");
            DropTable("dbo.Receptions");
            DropTable("dbo.Products");
            DropTable("dbo.PanelLineNumbers");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerLogs");
        }
    }
}
