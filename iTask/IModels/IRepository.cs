using System.Linq.Expressions;
using iTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public interface IRepository <T> where T : class
{
    public T? Get(Expression<Func<T, bool>> filter);
    public List<T> GetAll(); 

}