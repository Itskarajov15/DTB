using DTB.Infrastructure.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Article
{
    public class ArticleViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string AuthorId { get; set; } = null!;

        public string AuthorName { get; set; } = null!;

        public string DateOfCreation { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}
