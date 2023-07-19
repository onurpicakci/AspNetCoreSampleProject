using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Testimonials
{
    [Key]
    public int TestimonialsId { get; set; }
    
    public string ClientName { get; set; }
    
    public string Company { get; set; }
    
    public string ImageUrl { get; set; }
    
    public string Comment { get; set; }
}