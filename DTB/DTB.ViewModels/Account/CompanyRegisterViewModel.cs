using DTB.Core.Models.Categories;
using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Account
{
    public class CompanyRegisterViewModel
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$", ErrorMessage = "The password must have at least one lowercase letter, one uppercase letter, one digit, and one special character.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string CategoryId { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        public List<CategoryViewModel> Categories { get; set; } = new();

        public List<string> Errors { get; set; } = new();
    }
}