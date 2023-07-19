using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Message
{
    [Key]
    public int MessageId { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Content { get; set; }
    
    public DateTime Date { get; set; }
    
    public bool IsRead { get; set; }
}