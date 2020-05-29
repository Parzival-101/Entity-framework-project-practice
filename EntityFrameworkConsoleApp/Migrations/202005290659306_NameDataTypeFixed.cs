namespace EntityFrameworkConsoleApp.Migrations
{
    using System;
    using System.Data;
    using System.Data.Entity.Migrations;
    
    public partial class NameDataTypeFixed : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Videos DROP Constraint DF__Videos__Level__6E01572D");

            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Level", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "Level", c => c.Int(nullable: false));
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
        }
    }
}
