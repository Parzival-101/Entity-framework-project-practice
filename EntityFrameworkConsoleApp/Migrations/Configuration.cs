namespace EntityFrameworkConsoleApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkConsoleApp.VidzyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameworkConsoleApp.VidzyContext context)
        {
            context.Genres.AddOrUpdate(v => v.Name,
                new Genre { Name = "Horror" });  
        }
    }
}
