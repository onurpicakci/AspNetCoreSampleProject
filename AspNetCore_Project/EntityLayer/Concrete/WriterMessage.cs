using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class WriterMessage
{
    [Key]
    public int Id { get; set; }

    public string Sender { get; set; }

    public string SenderName { get; set; }
    
    public string Receiver { get; set; }

    public string ReceiverName { get; set; }
    
    public string Subject { get; set; }
    
    public string MessageContent { get; set; }
    
    public DateTime MessageDate { get; set; }
    
    
}