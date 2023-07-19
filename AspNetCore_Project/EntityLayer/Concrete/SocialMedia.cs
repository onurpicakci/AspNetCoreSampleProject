using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class SocialMedia
{
    [Key]
    public int SocialMediaId { get; set; }
    
    public string Name { get; set; }
    
    public string Icon { get; set; }
    
    public string Url { get; set; }
    
    public bool Status { get; set; }
}