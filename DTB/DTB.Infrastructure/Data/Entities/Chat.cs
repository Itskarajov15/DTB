using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class Chat
    {
        [Required]
        public string Id { get; set; } = null!;

        public List<Message> Messages { get; set; } = new();

        public List<BaseUser> Participants { get; set; } = new();
    }
}