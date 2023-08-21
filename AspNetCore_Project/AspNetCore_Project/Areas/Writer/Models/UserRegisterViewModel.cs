using System.ComponentModel.DataAnnotations;

namespace AspNetCore_Project.Areas.Writer.Models;

public class UserRegisterViewModel
{
    [Required(ErrorMessage = "Please enter your name")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Please enter your surname")]
    public string Surname { get; set; }
    
    [Required(ErrorMessage = "Please enter your username")]
    public string UserName { get; set; }
    
    [Required(ErrorMessage = "Please enter your password")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "Please enter your password")]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    public string PasswordConfirm { get; set; }
    
    [Required(ErrorMessage = "Please enter your mail address")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter your image url")]
    public string ImageUrl { get; set; }
}