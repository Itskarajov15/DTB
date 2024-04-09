using DTB.Infrastructure.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Job
{
    public class JobViewModel
    {
        public string Id { get; set; } = null!;

        public string Profession { get; set; } = null!;

        [StringLength(100)]
        public string Experience { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Company { get; set; } = null!;

        public List<User> Candidates { get; set; } = new();

        public string Location { get; set; } = null!;

        public string Category { get; set; } = null!;
    }
}
