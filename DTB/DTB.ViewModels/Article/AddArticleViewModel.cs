
using DTB.Infrastructure.Data.Entities;

namespace DTB.ViewModels.Article
{
    public class AddArticleViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string AuthorId { get; set; } = null!;

        public DateTime DateOfCreation { get; set; }

        public string ImageUrl { get; set; } = null!;
    }
}
