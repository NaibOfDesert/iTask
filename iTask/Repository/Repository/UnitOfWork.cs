
using iTask.Data;
public class UnitOfWork : IUnitOfWork
{
    public ApplicationDbContext _db; 
    public ITaskRepository task { get; set;}

    public UnitOfWork(ApplicationDbContext db){
        _db = db;
        task = new TaskRepository(db);  
    }
}