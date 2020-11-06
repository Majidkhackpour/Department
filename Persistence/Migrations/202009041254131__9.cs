namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SmsLogs", "Message", c => c.String());
            AddColumn("dbo.SmsLogs", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.SmsLogs", "MessageId", c => c.Long(nullable: false));
            AddColumn("dbo.SmsLogs", "StatusText", c => c.String(maxLength: 200));
            DropColumn("dbo.SmsLogs", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SmsLogs", "Description", c => c.String());
            DropColumn("dbo.SmsLogs", "StatusText");
            DropColumn("dbo.SmsLogs", "MessageId");
            DropColumn("dbo.SmsLogs", "Cost");
            DropColumn("dbo.SmsLogs", "Message");
        }
    }
}
