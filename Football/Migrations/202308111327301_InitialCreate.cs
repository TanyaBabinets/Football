namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        scoreTeam1 = c.Int(nullable: false),
                        scoreTeam2 = c.Int(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        number = c.Int(nullable: false),
                        position = c.String(maxLength: 50),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        country_Id = c.Int(),
                        Match_Id = c.Int(),
                        Match_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.country_Id)
                .ForeignKey("dbo.Matches", t => t.Match_Id)
                .ForeignKey("dbo.Matches", t => t.Match_Id1)
                .Index(t => t.country_Id)
                .Index(t => t.Match_Id)
                .Index(t => t.Match_Id1);
            
            CreateTable(
                "dbo.PlayerMatches",
                c => new
                    {
                        Player_Id = c.Int(nullable: false),
                        Match_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Player_Id, t.Match_Id })
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .ForeignKey("dbo.Matches", t => t.Match_Id, cascadeDelete: true)
                .Index(t => t.Player_Id)
                .Index(t => t.Match_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Match_Id1", "dbo.Matches");
            DropForeignKey("dbo.Teams", "Match_Id", "dbo.Matches");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "country_Id", "dbo.Countries");
            DropForeignKey("dbo.PlayerMatches", "Match_Id", "dbo.Matches");
            DropForeignKey("dbo.PlayerMatches", "Player_Id", "dbo.Players");
            DropIndex("dbo.PlayerMatches", new[] { "Match_Id" });
            DropIndex("dbo.PlayerMatches", new[] { "Player_Id" });
            DropIndex("dbo.Teams", new[] { "Match_Id1" });
            DropIndex("dbo.Teams", new[] { "Match_Id" });
            DropIndex("dbo.Teams", new[] { "country_Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Matches", new[] { "Team_Id" });
            DropTable("dbo.PlayerMatches");
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
            DropTable("dbo.Matches");
            DropTable("dbo.Countries");
        }
    }
}
