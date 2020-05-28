using System.Data.Entity;

namespace EntityFrameworkConsoleApp
{
        public class VidzyContext :DbContext
        {
            public DbSet<Video> Videos { get; set; }
            public DbSet<Genre> Genres { get; set; }

            public VidzyContext()
                :base("name =DefaultConnection")
            {

            }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Videos)
                .WithRequired(v => v.Genres);
        }
    }
}
