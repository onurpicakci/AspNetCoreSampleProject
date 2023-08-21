using System.ComponentModel.DataAnnotations;

namespace AspNetCore_Project.Areas.Writer.Models;

public class UserLoginViewModel
{
    [Display(Name = "User Name")]
    [Required(ErrorMessage = "User Name is required")]
    public string UserName { get; set; }
    
    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}