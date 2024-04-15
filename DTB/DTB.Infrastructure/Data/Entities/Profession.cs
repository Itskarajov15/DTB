using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTB.Infrastructure.Data.Entities
{
    public class Profession
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public string CategoryId { get; set; } = null!;
    }
}
