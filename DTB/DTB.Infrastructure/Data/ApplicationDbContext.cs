using DTB.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DTB.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<BaseUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<User> ApplicationUsers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Entities.File> Files { get; set; }

        public DbSet<JobAd> JobAds { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Profession> Professions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new List<Category>
                {
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Architecture, Construction",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png",
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Health and Pharmacy",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png",
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Drivers, Couriers",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png",
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Restaurants, Bars, Hotels, Tourism",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png",
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Engineers and Technicians",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png",
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Human Resources",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png",
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Media, Publishing",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png",
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Logistics, Spedition",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png",
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Logistics, Spedition",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png",
                    }
                });
        }
    }
}