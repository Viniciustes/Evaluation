using System.ComponentModel.DataAnnotations;

namespace Evaluation.Models.ViewModels.Account
{
    public class LoginViewModel
    {
        public LoginViewModel() { }

        public LoginViewModel(string returnUrl) => ReturnUrl = returnUrl;

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
