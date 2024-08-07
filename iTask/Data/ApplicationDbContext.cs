using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity; 
using Microsoft.AspNetCore.Identity;

namespace iTask.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Project> Projects { get; set; }
    public override DbSet<IdentityUser> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
      
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser {Name = "Admin", Email = "admin@admin.com", PasswordHash = "a1b2c3"}
        );

        modelBuilder.Entity<Project>().HasData(
            new Project {Id = 1, Name = "Project1", State = ProjectState.open}, 
            new Project {Id = 2, Name = "Project2", State = ProjectState.open},
            new Project {Id = 33, Name = "Project33", State = ProjectState.closed}
        );
        
        modelBuilder.Entity<Assignment>().HasData(
            new Assignment {Id = 1, State = AssigmnetsState.ToDo},
            new Assignment {Id = 2, State = AssigmnetsState.ToDo}
        );

    }

}

