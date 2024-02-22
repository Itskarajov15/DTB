namespace DTB.Infrastructure.Data.Entities
{
    public class Position
    {
        public string Id { get; set; } = null!;

        public string Profession { get; set; } = null!;

        public int Experience { get; set; } // Може като стринг и да се пише текст в него вместо години

        public List<string> Requirements { get; set; } = new();

        public string Description { get; set; } = null!;

        public Company Company { get; set; } = null!;

        public List<User> Candidates { get; set; } = new();

        public Location Location { get; set; } = new();

        public Category Category { get; set; } = new();
    }
}