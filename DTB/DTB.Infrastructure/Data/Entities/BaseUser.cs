using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public abstract class BaseUser : IdentityUser
    {
        [Required]
        public string ProfilePicture { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;
    }
}