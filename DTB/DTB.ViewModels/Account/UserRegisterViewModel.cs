using DTB.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Account
{
    public class UserRegisterViewModel
    {
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
        public string FirstName { get; set; } = null!;

        [Required]
        public string MiddleName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public Status Status { get; set; }

        public List<string> Errors { get; set; } = new();
    }
}