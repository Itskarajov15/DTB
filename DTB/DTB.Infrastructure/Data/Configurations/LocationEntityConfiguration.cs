using DTB.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTB.Infrastructure.Data.Configurations
{
    public class LocationEntityConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new List<Location>
                {
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Sofia"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Burgas"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Plovdiv"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Varna"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Yambol"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Blagoevgrad"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Sliven"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Dimitrovgrad"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Ruse"
                    },
                    new Location
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Elhovo"
                    },
                });
        }
    }
}