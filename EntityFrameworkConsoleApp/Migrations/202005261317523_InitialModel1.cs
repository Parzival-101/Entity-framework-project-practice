namespace EntityFrameworkConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Genres", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.Genres", "Video_Id1", "dbo.Videos");
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Genres", new[] { "Video_Id" });
            DropIndex("dbo.Genres", new[] { "Video_Id1" });
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        Video_Id = c.Int(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_Id, t.Genre_Id })
                .ForeignKey("dbo.Videos", t => t.Video_Id, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Video_Id)
                .Index(t => t.Genre_Id);
            
            DropColumn("dbo.Genres", "Video_Id");
            DropColumn("dbo.Genres", "Video_Id1");
            DropColumn("dbo.Videos", "Genre_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Videos", "Genre_Id", c => c.Int());
            AddColumn("dbo.Genres", "Video_Id1", c => c.Int());
            AddColumn("dbo.Genres", "Video_Id", c => c.Int());
            DropForeignKey("dbo.VideoGenres", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.VideoGenres", "Video_Id", "dbo.Videos");
            DropIndex("dbo.VideoGenres", new[] { "Genre_Id" });
            DropIndex("dbo.VideoGenres", new[] { "Video_Id" });
            DropTable("dbo.VideoGenres");
            CreateIndex("dbo.Videos", "Genre_Id");
            CreateIndex("dbo.Genres", "Video_Id1");
            CreateIndex("dbo.Genres", "Video_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Genres", "Video_Id1", "dbo.Videos", "Id");
            AddForeignKey("dbo.Genres", "Video_Id", "dbo.Videos", "Id");
        }
    }
}
