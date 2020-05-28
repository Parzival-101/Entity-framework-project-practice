namespace EntityFrameworkConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_ClassificationOnVideo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Level", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Level");
        }
    }
}
