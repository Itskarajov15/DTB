namespace DTB.Infrastructure.Data.Entities
{
    public class Article
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public BaseUser Author { get; set; } = null!;

        public DateTime DateOfCreation { get; set; }

        public List<Comment> Messages { get; set; } = new();
    }
}