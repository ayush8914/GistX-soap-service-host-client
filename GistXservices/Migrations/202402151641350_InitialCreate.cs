namespace GistXservices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GistId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Gists", t => t.GistId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.GistId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Gists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        fileName = c.String(),
                        Content = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.GistUsers",
                c => new
                    {
                        GistId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GistId, t.UserId })
                .ForeignKey("dbo.Gists", t => t.GistId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.GistId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Forks", "UserId", "dbo.Users");
            DropForeignKey("dbo.Gists", "UserId", "dbo.Users");
            DropForeignKey("dbo.GistUsers", "UserId", "dbo.Users");
            DropForeignKey("dbo.GistUsers", "GistId", "dbo.Gists");
            DropForeignKey("dbo.Forks", "GistId", "dbo.Gists");
            DropIndex("dbo.GistUsers", new[] { "UserId" });
            DropIndex("dbo.GistUsers", new[] { "GistId" });
            DropIndex("dbo.Gists", new[] { "UserId" });
            DropIndex("dbo.Forks", new[] { "UserId" });
            DropIndex("dbo.Forks", new[] { "GistId" });
            DropTable("dbo.Users");
            DropTable("dbo.GistUsers");
            DropTable("dbo.Gists");
            DropTable("dbo.Forks");
        }
    }
}
