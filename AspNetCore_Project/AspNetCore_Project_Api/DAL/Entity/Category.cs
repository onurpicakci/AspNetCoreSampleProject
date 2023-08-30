using System.ComponentModel.DataAnnotations;

namespace AspNetCore_Project_Api.DAL.Entity;

public class Category
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
}