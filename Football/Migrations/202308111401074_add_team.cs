namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_team : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Players", new[] { "Team_Id" });
            CreateIndex("dbo.Players", "team_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Players", new[] { "team_Id" });
            CreateIndex("dbo.Players", "Team_Id");
        }
    }
}
