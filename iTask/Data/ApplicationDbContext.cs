using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity; 
using Microsoft.AspNetCore.Identity;

namespace iTask.Data;

public class ApplicationDbContext : IdentityDbContext
{
    private readonly UserManager<IdentityUser> _userMenager; 
    public DbSet<Assignment> TaAssignments { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, UserManager<IdentityUser> userMenager) : base(options)
    {
        _userMenager = userMenager;
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);

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

