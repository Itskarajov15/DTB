using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class Category
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        public List<JobAd> JobAds { get; set; } = new();

        [Required]
        public string PictureUrl { get; set; } = null!;

        public List<Company> Companies { get; set; } = new();

        public List<Profession> Professions { get; set; } = new();

        public DateTime DateOfCreation { get; set; }
    }
}