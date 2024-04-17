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
                        Id = "9b51ab5b-59a6-4e02-b883-27e2085e5ad3",
                        Name = "Sofia"
                    },
                    new Location
                    {
                        Id = "f83622f2-b418-4a1a-9dcb-24d0e79c9b7b",
                        Name = "Burgas"
                    },
                    new Location
                    {
                        Id = "271f8045-12b1-4042-b930-d95cb98b687d",
                        Name = "Plovdiv"
                    },
                    new Location
                    {
                        Id = "fdcd7e7e-eb16-4ef3-bfbf-164340f6a0d3",
                        Name = "Varna"
                    },
                    new Location
                    {
                        Id = "bedffed3-610d-4b60-8ac4-b35bc1707f4f",
                        Name = "Yambol"
                    },
                    new Location
                    {
                        Id = "0212d51d-5cc7-41c6-91b4-8b7237882442",
                        Name = "Blagoevgrad"
                    },
                    new Location
                    {
                        Id = "be267067-1415-4d9c-9d45-ef62b1588c58",
                        Name = "Sliven"
                    },
                    new Location
                    {
                        Id = "1dbfe0e6-d4cb-46e8-a6cc-0a0c1f60f6de",
                        Name = "Dimitrovgrad"
                    },
                    new Location
                    {
                        Id = "79f47c1b-0975-42e7-8b94-12e3e3bbd319",
                        Name = "Ruse"
                    },
                    new Location
                    {
                        Id = "2dafea3b-3d3a-46da-a2d4-3a1ad7ab953a",
                        Name = "Elhovo"
                    },
                });
        }
    }
}