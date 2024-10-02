using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using iTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _db; 
    public DbSet<T> dbSet;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
        dbSet = db.Set<T>();
    }

    public T GetById(int id){

        return dbSet.FirstOrDefault(T t => t.Id == id);
    }

    public List<T> GetAll()
    {
        IQueryable<T> query = dbSet; 
        return query.ToList();     
    }
}