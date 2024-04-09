using DTB.Core.Models.Categories;
using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Profession
{
    public class ProfessionViewModel
    {
        public string Id { get; set; } = null!;

        [StringLength(100)]
        public string Name { get; set; } = null!;

        public CategoryViewModel Category { get; set; } = null!;
    }
}
