namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_tellPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "tel", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "tel");
        }
    }
}
