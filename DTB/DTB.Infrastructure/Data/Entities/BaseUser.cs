using Microsoft.AspNetCore.Identity;

namespace DTB.Infrastructure.Data.Entities
{
    public class BaseUser : IdentityUser
    {
        public string? ProfilePicture { get; set; }

        public string? Description { get; set; }
    }
}