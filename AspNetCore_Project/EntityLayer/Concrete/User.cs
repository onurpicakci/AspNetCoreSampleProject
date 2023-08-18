using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class User
{
    [Key]
    public int UserId { get; set; }
    
    public string Name { get; set; }
    
    public string Surname { get; set; }
    
    public string UserName { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public string ImageUrl { get; set; }

    public bool Status { get; set; }

    public List<UserMessage> UserMessages { get; set; }
}