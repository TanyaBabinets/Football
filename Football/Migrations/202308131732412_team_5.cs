namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class team_5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "Match_Id", "dbo.Matches");
            DropForeignKey("dbo.Teams", "Match_Id1", "dbo.Matches");
            DropIndex("dbo.Teams", new[] { "Match_Id" });
            DropIndex("dbo.Teams", new[] { "Match_Id1" });
            AddColumn("dbo.Matches", "team_One_Id", c => c.Int());
            AddColumn("dbo.Matches", "team_Two_Id", c => c.Int());
            CreateIndex("dbo.Matches", "team_One_Id");
            CreateIndex("dbo.Matches", "team_Two_Id");
            AddForeignKey("dbo.Matches", "team_One_Id", "dbo.Teams", "Id");
            AddForeignKey("dbo.Matches", "team_Two_Id", "dbo.Teams", "Id");
            DropColumn("dbo.Teams", "Match_Id");
            DropColumn("dbo.Teams", "Match_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Match_Id1", c => c.Int());
            AddColumn("dbo.Teams", "Match_Id", c => c.Int());
            DropForeignKey("dbo.Matches", "team_Two_Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "team_One_Id", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "team_Two_Id" });
            DropIndex("dbo.Matches", new[] { "team_One_Id" });
            DropColumn("dbo.Matches", "team_Two_Id");
            DropColumn("dbo.Matches", "team_One_Id");
            CreateIndex("dbo.Teams", "Match_Id1");
            CreateIndex("dbo.Teams", "Match_Id");
            AddForeignKey("dbo.Teams", "Match_Id1", "dbo.Matches", "Id");
            AddForeignKey("dbo.Teams", "Match_Id", "dbo.Matches", "Id");
        }
    }
}
