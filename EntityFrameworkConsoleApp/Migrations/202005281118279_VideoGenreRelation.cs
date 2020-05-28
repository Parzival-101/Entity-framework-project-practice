namespace EntityFrameworkConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VideoGenreRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genres_Id" });
            AlterColumn("dbo.Videos", "Genres_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "Genres_Id");
            AddForeignKey("dbo.Videos", "Genres_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genres_Id" });
            AlterColumn("dbo.Videos", "Genres_Id", c => c.Int());
            CreateIndex("dbo.Videos", "Genres_Id");
            AddForeignKey("dbo.Videos", "Genres_Id", "dbo.Genres", "Id");
        }
    }
}
