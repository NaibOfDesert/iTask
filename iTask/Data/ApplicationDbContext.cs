using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace iTask.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Project> Projects { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
    base.OnModelCreating(modelBuilder);

    
    modelBuilder.Entity<Project>().HasData(
        new Project {Id = 1, Name = "Project1"}, 
        new Project {Id = 2, Name = "Project2"},
        new Project {Id = 33, Name = "Project33"},
        new Project {Id = 34, Name = "Project34"}

    );
    }
}

