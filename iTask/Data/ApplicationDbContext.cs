using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace iTask.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //public DbSet DbSet<ApplicationUser> Users { get;}
    public DbSet<Assignment> TaAssignments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Project>().HasData(
            new Project {Id = 1}, 
            new Project {Id = 2}
        );
        
        modelBuilder.Entity<Assignment>().HasData(
            new Assignment {Id = 1},
            new Assignment {Id = 2}
        );

    }

}

