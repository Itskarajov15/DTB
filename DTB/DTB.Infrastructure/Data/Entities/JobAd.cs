namespace DTB.Infrastructure.Data.Entities
{
    public class JobAd
    {
        public string Id { get; set; } = null!;

        public Profession Profession { get; set; } = null!;

        public string Experience { get; set; } = null!;

        public string Description { get; set; } = null!;

        public Company Company { get; set; } = null!;

        public List<User> Candidates { get; set; } = new();

        public Location Location { get; set; } = new();

        public Category Category { get; set; } = new();
    }
}