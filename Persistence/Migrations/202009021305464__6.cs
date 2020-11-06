namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CompanyName", c => c.String(maxLength: 100));
            AddColumn("dbo.Products", "BckUpPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "BckUpPrice");
            DropColumn("dbo.Customers", "CompanyName");
        }
    }
}
