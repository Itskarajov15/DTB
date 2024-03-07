namespace DTB.Infrastructure.Data.Entities
{
    public class Comment
    {
        public string Id { get; set; } = null!;

        public string Content { get; set; } = null!;

        public BaseUser Author { get; set; } = null!;

        public Article Article { get; set; } = null!;
    }
}