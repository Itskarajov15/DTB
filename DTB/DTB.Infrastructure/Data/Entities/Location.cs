namespace DTB.Infrastructure.Data.Entities
{
    public class Location
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public List<Company> Companies { get; set; } = new();
    }
}