using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTB.Infrastructure.Data.Entities
{
    public class JobAd
    {
        [Required]
        public string Id { get; set; } = null!;

        [ForeignKey(nameof(Profession))]
        public string ProfessionId { get; set; } = null!;

        public Profession Profession { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Experience { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public Company Company { get; set; } = null!;

        public List<User> Candidates { get; set; } = new();

        public Location Location { get; set; } = new();

        public Category Category { get; set; } = new();
    }
}