namespace DTB.Infrastructure.Data.Entities
{
    public class Category
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public List<JobAd> JobAds { get; set; } = new();

        public string PictureUrl { get; set; } = null!;

        public List<Company> Companies { get; set; } = new();

        public List<Profession> Professions { get; set; } = new();
    }
}