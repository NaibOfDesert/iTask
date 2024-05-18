using iTask.Data;
using Microsoft.EntityFrameworkCore;

public interface IRepository <T> where T : class
{
    public IEnumerable<T> GetAll(); 

}