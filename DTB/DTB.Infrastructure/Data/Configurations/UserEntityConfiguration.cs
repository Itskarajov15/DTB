using DTB.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTB.Infrastructure.Data.Configurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = "cad23a9b-e215-45e8-823f-87207f8c2b71",
                    Email = "test@abv.bg",
                    NormalizedUserName = "test@abv.bg",
                    UserName = "test",
                    PasswordHash = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b",
                    FirstName = "Test",
                    MiddleName = "Testov",
                    LastName = "Testov",
                });
        }
    }
}