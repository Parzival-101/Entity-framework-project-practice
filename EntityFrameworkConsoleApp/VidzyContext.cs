using System.Data.Entity;

namespace EntityFrameworkConsoleApp
{
        public class VidzyContext :DbContext
        {
            public DbSet<Video> Videos { get; set; }
            public DbSet<Genre> Genres { get; set; }
            public DbSet<Tag> Tags { get; set; }

            public VidzyContext()
                :base("name =DefaultConnection")
            {

            }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Videos)
                .WithRequired(v => v.Genres);

            modelBuilder.Entity<Video>()
                .Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Video>()
                .HasMany(v => v.Tags)
                .WithOptional(t => t.Videos)
                .Map(m =>
                {
                    m.MapKey("VideoId");
                });
                
            modelBuilder.Entity<Genre>()
                .Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
