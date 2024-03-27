using DTB.Core.Models.Categories;
using DTB.Core.Models.Locations;

namespace DTB.Models
{
    public class HomePageViewModel
    {
        public List<CategoryViewModel> Categories { get; set; } = new();

        public List<LocationViewModel> Locations { get; set; } = new();
    }
}