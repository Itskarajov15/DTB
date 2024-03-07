namespace DTB.Infrastructure.Data.Entities
{
    public class Profession
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public Category Category { get; set; } = null!;
    }
}
