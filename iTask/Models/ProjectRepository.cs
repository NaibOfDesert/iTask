using iTask.Data;
using Microsoft.EntityFrameworkCore;

public class ProjectRepository : Repository<Project>, IProjectRepository
{
    private readonly ApplicationDbContext _db;
    public ProjectRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void AddAssignment(Project project, Assignment assignment)
    {
        project.Assignments.Add(assignment); 
    }

    public void RemoveAssignment(Project project, Assignment assignment)
    {
    project.Assignments.Add(assignment); 
    }

    public int GetCount(Project project)
    {
        return project.Assignments.Count();
    }


}