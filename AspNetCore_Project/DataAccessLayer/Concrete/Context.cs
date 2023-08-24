using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete;

public class Context : IdentityDbContext<WriterUser, WriterRole, int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=AspNetCore_Project;User Id=sa;Password=myPassw0rd;TrustServerCertificate=True;");
    }

    public DbSet<About> Abouts { get; set; }
    
    public DbSet<Contact> Contacts { get; set; }
    
    public DbSet<Experience> Experiences { get; set; }
    
    public DbSet<Feature> Features { get; set; }
    
    public DbSet<Message> Messages { get; set; }
    
    public DbSet<Portfolio> Portfolios { get; set; }
    
    public DbSet<Service> Services { get; set; }
    
    public DbSet<Skill> Skills { get; set; }
    
    public DbSet<SocialMedia> SocialMedias { get; set; }
    
    public DbSet<Testimonials> Testimonial { get; set; }
    
    public DbSet<User> Users { get; set; }
    public DbSet<UserMessage> UserMessages { get; set; }
    
    public DbSet<ToDoList> ToDoLists { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    
    public DbSet<WriterMessage> WriterMessages { get; set; }
}