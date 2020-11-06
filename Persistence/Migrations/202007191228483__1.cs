namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Name = c.String(maxLength: 200),
                        UserName = c.String(maxLength: 200),
                        Password = c.String(maxLength: 100),
                        Mobile = c.String(maxLength: 20),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Guid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
