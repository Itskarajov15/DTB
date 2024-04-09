using DTB.Core.Models.Categories;
using DTB.Core.Models.Locations;
using DTB.Infrastructure.Data.Entities;
using DTB.ViewModels.Job;
using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Company
{
    public class CompanyViewModel
    {
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(255)]
        public string Address { get; set; } = null!;

        public CategoryViewModel Category { get; set; } = null!;

        public List<JobAdViewModel> JobAds { get; set; } = new();

        public List<LocationViewModel> Locations { get; set; } = new();
    }
}
