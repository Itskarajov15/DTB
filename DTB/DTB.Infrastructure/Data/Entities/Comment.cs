using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class Comment
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;

        public BaseUser Author { get; set; } = null!;

        public Article Article { get; set; } = null!;
    }
}