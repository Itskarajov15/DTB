using DTB.Core.Models.Categories;
using DTB.Core.Models.Locations;
using DTB.Infrastructure.Data.Entities;
using DTB.ViewModels.Company;
using DTB.ViewModels.Profession;
using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Job
{
    public class GetAllJobsViewModel
    {
        public string Id { get; set; } = null!;

        public string Profession { get; set; } = null!;

        public string Experience { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Company { get; set; } = null!;

        public string Location { get; set; } = null!;

        public string Category { get; set; } = null!;
    }
}
