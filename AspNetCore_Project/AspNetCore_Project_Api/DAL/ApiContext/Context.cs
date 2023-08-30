using AspNetCore_Project_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_Project_Api.DAL.ApiContext;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=AspNetCore_Project2;User Id=sa;Password=myPassw0rd;TrustServerCertificate=True;");
    }
    
    public DbSet<Category> Categories { get; set; }
}