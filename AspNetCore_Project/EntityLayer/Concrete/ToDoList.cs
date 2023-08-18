using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class ToDoList
{
    [Key]
    public int Id { get; set; }

    public string Content { get; set; }
    
    public bool Status { get; set; }
}