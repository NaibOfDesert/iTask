using System.Linq.Expressions;
using iTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public interface IRepository <T> where T : class
{
    public T? Get(Expression<Func<T, bool>> filter);
    public List<T> GetAll(); 

    public int Count(Expression<Func<T, bool>> filter); 

    public void Add(T entity);
    public void Update(T entity);  
    public void Remove(T entity);
}