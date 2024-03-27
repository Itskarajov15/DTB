using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class ContactFormSubmission
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;
    }
}
