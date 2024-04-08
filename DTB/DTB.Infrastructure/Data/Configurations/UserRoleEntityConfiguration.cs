using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTB.Infrastructure.Data.Configurations
{
    public class UserRoleEntityConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new List<IdentityRole>() {
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = Guid.NewGuid().ToString()
                },
                new IdentityRole
                {
                    Name = "Company",
                    NormalizedName = "COMPANY",
                    Id = Guid.NewGuid().ToString()
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    Id = Guid.NewGuid().ToString()
                }
            });
        }
    }
}