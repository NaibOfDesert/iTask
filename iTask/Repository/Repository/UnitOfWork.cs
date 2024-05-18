
using iTask.Data;
public class UnitOfWork : IUnitOfWork
{
    public ApplicationDbContext _db; 
    public ITaskRepository tasks { get; private set;}

    public UnitOfWork(ApplicationDbContext db){
        _db = db;
        tasks = new TaskRepository(db);  
    }
}