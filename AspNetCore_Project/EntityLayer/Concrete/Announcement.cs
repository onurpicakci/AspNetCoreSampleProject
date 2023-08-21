using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Announcement
{
    [Key]
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public DateTime Date { get; set; }
    
    public bool Status { get; set; }
    
    public string Content { get; set; }
    
}