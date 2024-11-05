using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace iTask.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<AppUser> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Assignment> Assignments{ get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
    base.OnModelCreating(modelBuilder);

    
    modelBuilder.Entity<Project>().HasData(
        new Project {Id = 1, Name = "iTask"}, 
        new Project {Id = 2, Name = "SoShops"},
        new Project {Id = 3, Name = "Travelski"},
        new Project {Id = 4, Name = "Bybye"}
    );
    }
}

