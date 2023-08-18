using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class UserMessage
{
    [Key]
    public int MessageId { get; set; }
    
    public string Title { get; set; }
    
    public string Content { get; set; }
    
    public DateTime Date { get; set; }
    
    public bool IsRead { get; set; }

    public int UserId { get; set; }

    public User User { get; set; }
}