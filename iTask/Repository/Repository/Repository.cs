using iTask.Data;
using Microsoft.EntityFrameworkCore;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _db; 
    public DbSet<T> dbSet;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
        dbSet = db.Set<T>();
    }
    public IEnumerable<T> GetAll()
    {
        IQueryable<T> query = dbSet; 
        return query.ToList(); 
    }
}