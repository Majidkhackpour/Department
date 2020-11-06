namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Code");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Code", c => c.String(maxLength: 10));
        }
    }
}
