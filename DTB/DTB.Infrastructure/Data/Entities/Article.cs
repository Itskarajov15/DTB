using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; } = null!;

        public User Author { get; set; } = null!;

        public DateTime DateOfCreation { get; set; }

        public List<Comment> Comments { get; set; } = new();

        [Required]
        public string ImageUrl { get; set; } = null!;
    }
}