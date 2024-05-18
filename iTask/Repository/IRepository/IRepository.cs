using iTask.Data;
using Microsoft.EntityFrameworkCore;

public interface IRepository <T> where T : class
{
    protected ApplicationDbContext _db; 
    protected DbSet<T> dbSet; 
    protected IEnumerable<T> GetAll(); 

}