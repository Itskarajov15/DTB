using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class Company : BaseUser
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(255)]
        public string Address { get; set; } = null!;

        public Category Category { get; set; } = null!;

        public List<JobAd> JobAds { get; set; } = new();

        public List<Location> Locations { get; set; } = new();
    }
}