using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class File
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(250)]
        public string Name { get; set; } = null!;

        public List<byte> Content { get; set; } = new();
    }
}