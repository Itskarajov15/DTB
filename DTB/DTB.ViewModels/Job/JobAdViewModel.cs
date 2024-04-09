using DTB.Core.Models.Categories;
using DTB.Core.Models.Locations;
using DTB.Infrastructure.Data.Entities;
using DTB.ViewModels.Company;
using DTB.ViewModels.Profession;
using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Job
{
    public class JobAdViewModel
    {
        public string Id { get; set; } = null!;

        public ProfessionViewModel Profession { get; set; } = null!;

        [StringLength(100)]
        public string Experience { get; set; } = null!;

        public string Description { get; set; } = null!;

        public CompanyViewModel Company { get; set; } = null!;

        public List<User> Candidates { get; set; } = new();

        public LocationViewModel Location { get; set; } = new();

        public CategoryViewModel Category { get; set; } = new();
    }
}
