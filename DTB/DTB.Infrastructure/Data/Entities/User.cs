using DTB.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Entities
{
    public class User : BaseUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string MiddleName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        public Profession? Profession { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<File> Files { get; set; } = new();

        public Status Status { get; set; }
    }
}