using iTask.Data;
using Microsoft.EntityFrameworkCore;

public interface IRepository <T> where T : class
{
    public List<T> GetAll(); 

}