using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Portfolio
{
    [Key]
    public int PortfolioId { get; set; }
    
    public string Name { get; set; }
    
    public string ImageUrl { get; set; }
    
    public string ProjectUrl { get; set; }
    
    public string ImageUrl2 { get; set; }
}