namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_tel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Players", "tel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "tel", c => c.String(maxLength: 50));
        }
    }
}
