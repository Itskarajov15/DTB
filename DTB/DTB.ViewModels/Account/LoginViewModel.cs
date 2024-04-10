using System.ComponentModel.DataAnnotations;

namespace DTB.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public List<string> Errors { get; set; } = new();
    }
}