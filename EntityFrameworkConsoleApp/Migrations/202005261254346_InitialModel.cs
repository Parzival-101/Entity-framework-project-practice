namespace EntityFrameworkConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Video_Id = c.Int(),
                        Video_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Videos", t => t.Video_Id)
                .ForeignKey("dbo.Videos", t => t.Video_Id1)
                .Index(t => t.Video_Id)
                .Index(t => t.Video_Id1);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleasedDate = c.DateTime(),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Genre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Genres", "Video_Id1", "dbo.Videos");
            DropForeignKey("dbo.Genres", "Video_Id", "dbo.Videos");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            DropIndex("dbo.Genres", new[] { "Video_Id1" });
            DropIndex("dbo.Genres", new[] { "Video_Id" });
            DropTable("dbo.Videos");
            DropTable("dbo.Genres");
        }
    }
}
