using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class Article
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;

        public BaseUser Author { get; set; } = null!;

        public DateTime DateOfCreation { get; set; }

        public List<Comment> Comments { get; set; } = new();
    }
}