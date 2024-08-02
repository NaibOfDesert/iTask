using iTask.Data;
using Microsoft.EntityFrameworkCore;

public class ProjectRepository : Repository<Project>, IProjectRepository
{
    private readonly ApplicationDbContext _db;
    // public List<Assignment> assignmentList;
    public ProjectRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
        dbSet = _db.Set<Project>();
    }

    public new List<Project> GetAll() {

        return _db.Set<Project>().ToList();
    }
}