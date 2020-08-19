namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SmsPanels", "Name", c => c.String(maxLength: 200));
            AddColumn("dbo.SmsPanels", "LineNumber", c => c.String(maxLength: 200));
            DropColumn("dbo.SmsPanels", "UserName");
            DropColumn("dbo.SmsPanels", "Password");
            DropTable("dbo.PanelLineNumbers");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.SmsPanels", "Password", c => c.String(maxLength: 200));
            AddColumn("dbo.SmsPanels", "UserName", c => c.String(maxLength: 200));
            DropColumn("dbo.SmsPanels", "LineNumber");
            DropColumn("dbo.SmsPanels", "Name");
        }
    }
}
