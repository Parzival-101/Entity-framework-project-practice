namespace EntityFrameworkConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTagTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        VideoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Videos", t => t.VideoId)
                .Index(t => t.VideoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "VideoId", "dbo.Videos");
            DropIndex("dbo.Tags", new[] { "VideoId" });
            DropTable("dbo.Tags");
        }
    }
}
