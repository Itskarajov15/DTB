using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class Location
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        public List<Company> Companies { get; set; } = new();
    }
}