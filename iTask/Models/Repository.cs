using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using iTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _db; 
    public DbSet<T> _dbSet;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
        _dbSet = _db.Set<T>();
    }

    // TOCHECK: Expression & Func to verify.
    public T? Get(Expression<Func<T, bool>> filter){

        return _dbSet.Where(filter).FirstOrDefault();
    }

    public List<T> GetAll()
    {
        IQueryable<T> query = _dbSet; 
        return query.ToList();     
    }
    public List<T> GetAll(Expression<Func<T, bool>> filter)
    {
        IQueryable<T> query = _dbSet; 
        return query.Where(filter).ToList();     
    }

    public int Count(Expression<Func<T, bool>> filter){
        return _dbSet.Where(filter).Count();
    }
    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }
    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }
    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }
}