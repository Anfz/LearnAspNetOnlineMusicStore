namespace MvcMusicStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            /* CreateTable(
                 "dbo.Albums",
                 c => new
                     {
                         AlbumID = c.Int(nullable: false, identity: true),
                         Title = c.String(),
                         Artist_ArtistID = c.Int(),
                     })
                 .PrimaryKey(t => t.AlbumID)
                 .ForeignKey("dbo.Artists", t => t.Artist_ArtistID)
                 .Index(t => t.Artist_ArtistID);

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
                         ReviewerEmail = c.String(nullable: false),
                     })
                 .PrimaryKey(t => t.ReviewID)
                 .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                 .Index(t => t.AlbumId);
              */
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        TrackID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Album_AlbumID = c.Int(),
                    })
                .PrimaryKey(t => t.TrackID)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID)
                .Index(t => t.Album_AlbumID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tracks", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.Reviews", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Tracks", new[] { "Album_AlbumID" });
            DropIndex("dbo.Reviews", new[] { "AlbumId" });
            DropIndex("dbo.Albums", new[] { "Artist_ArtistID" });
            DropTable("dbo.Tracks");
            DropTable("dbo.Reviews");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
