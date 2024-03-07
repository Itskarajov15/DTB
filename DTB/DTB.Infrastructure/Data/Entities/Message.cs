using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class Message
    {
        [Required]
        public string Id { get; set; } = null!;

        public BaseUser Sender { get; set; } = null!;

        public BaseUser Receiver { get; set; } = null!;

        public Chat Chat { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;
    }
}