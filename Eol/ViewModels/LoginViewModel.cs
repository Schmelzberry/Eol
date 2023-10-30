using System.ComponentModel.DataAnnotations;

namespace Eol.ViewModels
{
  public class LoginViewModel
  {
    // [Required]
    // [EmailAddress]
    // [Display(Name = "Email Address")]
    // public string Email { get; set; }

    [Required]
    [Display(Name = "User Name")]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}
