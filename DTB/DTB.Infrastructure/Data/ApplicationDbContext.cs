﻿using DTB.Infrastructure.Data.Configurations;
using DTB.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
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

        public DbSet<ContactFormSubmission> ContactFormSubmissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new CategoryEntityConfiguration().Configure(builder.Entity<Category>());
            new LocationEntityConfiguration().Configure(builder.Entity<Location>());
            new UserRoleEntityConfiguration().Configure(builder.Entity<IdentityRole>());
            new UserEntityConfiguration().Configure(builder.Entity<User>());
            new ArticleEntityConfiguration().Configure(builder.Entity<Article>());
            new ProfessionEntityConfiguration().Configure(builder.Entity<Profession>()); 

            base.OnModelCreating(builder);
        }
    }
}