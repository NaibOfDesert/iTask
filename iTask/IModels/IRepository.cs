using iTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public interface IRepository <T> where T : class
{
    public T GetById(int id);
    public List<T> GetAll(); 

}