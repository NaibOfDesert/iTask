using iTask.Data;
using Microsoft.EntityFrameworkCore;

public class ProjectRepository : Repository<Project>, IProjectRepository
{
    private readonly ApplicationDbContext _db;
    public DbSet<Project> dbSet; 
    public ProjectRepository(ApplicationDbContext db) : base (db)
    {
        _db = db;
        dbSet = _db.Set<Project>();
    }
    public List<Project> GetAll(){
        IQueryable<Project> query = dbSet;
        return query.ToList();
    }
}