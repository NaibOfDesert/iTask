using iTask.Data;
using Microsoft.EntityFrameworkCore;

public class ProjectRepository : Repository<Project>, IProjectRepository
{
    private readonly ApplicationDbContext _db;
    public ProjectRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
}