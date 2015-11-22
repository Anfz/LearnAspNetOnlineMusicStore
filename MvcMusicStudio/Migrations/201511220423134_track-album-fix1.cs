namespace MvcMusicStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trackalbumfix1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tracks", "Album_AlbumID", "dbo.Albums");
            DropIndex("dbo.Tracks", new[] { "Album_AlbumID" });
            RenameColumn(table: "dbo.Tracks", name: "Album_AlbumID", newName: "AlbumId");
            AlterColumn("dbo.Tracks", "AlbumId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tracks", "AlbumId");
            AddForeignKey("dbo.Tracks", "AlbumId", "dbo.Albums", "AlbumID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tracks", "AlbumId", "dbo.Albums");
            DropIndex("dbo.Tracks", new[] { "AlbumId" });
            AlterColumn("dbo.Tracks", "AlbumId", c => c.Int());
            RenameColumn(table: "dbo.Tracks", name: "AlbumId", newName: "Album_AlbumID");
            CreateIndex("dbo.Tracks", "Album_AlbumID");
            AddForeignKey("dbo.Tracks", "Album_AlbumID", "dbo.Albums", "AlbumID");
        }
    }
}
