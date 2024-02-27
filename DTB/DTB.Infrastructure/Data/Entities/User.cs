using DTB.Infrastructure.Data.Enums;

namespace DTB.Infrastructure.Data.Entities
{
    public class User : BaseUser
    {
        public string FirstName { get; set; } = null!;

        public string MiddleName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Profession { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public List<File> Files { get; set; } = new();

        public Status Status { get; set; }
    }
}