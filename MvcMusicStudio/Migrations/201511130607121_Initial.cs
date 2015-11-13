namespace MvcMusicStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        AlbumId = c.Int(nullable: false),
                        Contents = c.String(),
                        ReviewerEmail = c.String(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .Index(t => t.AlbumId);
            
            AddColumn("dbo.Albums", "Artist_ArtistID", c => c.Int());
            CreateIndex("dbo.Albums", "Artist_ArtistID");
            AddForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists", "ArtistID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Reviews", new[] { "AlbumId" });
            DropIndex("dbo.Albums", new[] { "Artist_ArtistID" });
            DropColumn("dbo.Albums", "Artist_ArtistID");
            DropTable("dbo.Reviews");
            DropTable("dbo.Artists");
        }
    }
}
