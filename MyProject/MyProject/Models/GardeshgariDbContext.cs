using Microsoft.EntityFrameworkCore;

namespace MyProject.Models
{
    public class GardeshgariDbContext:DbContext
    {
        public GardeshgariDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Pagegroup> Pagegroups { get; set; }// Table "citys" in DBMS
        public DbSet<Pagesloc> Pageslocs { get; set; }// Table "locations" in DBMS

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pagegroup>(entity =>
            {
                entity.HasKey(e => e.GroupID);
                entity.Property(e => e.GroupID).ValueGeneratedNever();
                entity.HasData(
                    new Pagegroup() { GroupID = 10, GroupTitle = "خرم اباد " },
                    new Pagegroup() { GroupID = 11, GroupTitle = "الشتر  " },
                    new Pagegroup() { GroupID = 12, GroupTitle = " دورود  " }

                    );

            });

            modelBuilder.Entity<Pagesloc>(entity =>
            {
                entity.HasKey(e => e.PageID);
                entity.Property(e => e.PageID).ValueGeneratedNever();

                //یدونه مکان برای یک شهره hasone
                entity.HasOne(e => e.Pagegroup)

                //یدونه شهر برای چند مکانه
                .WithMany(e => e.Pageslocs)
                .HasForeignKey(e => e.GroupID);

                //entity.HasData(
                    //new Pagesloc() { PageID = 1000, Title = "شهر خرم اباد ", ShortDescription = "قلعه فلک الافلاک", Text = "خرم اباد", ImageName = , CreateDate = "" = "#خرم آباد " },

                    //);
            });
       }    
    }
}
