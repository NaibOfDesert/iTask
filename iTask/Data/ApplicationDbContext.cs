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
        new Project {Id = 1, Name = "BasicProject"}, 
        new Project {Id = 2, Name = "Project2"},
        new Project {Id = 3, Name = "Project3"},
        new Project {Id = 4, Name = "Project4"}
    );

    modelBuilder.Entity<Assignment>().HasData(
        new Assignment {Id = 1, IdProject = 1, Name = "Test1"},
        new Assignment {Id = 2, IdProject = 2, Name = "Test2"},
        new Assignment {Id = 3, IdProject = 3, Name = "Test3"}
    );

    }
}

