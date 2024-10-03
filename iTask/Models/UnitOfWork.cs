

using iTask.Data;
public class UnitOfWork : IUnitOfWork
{
    public ApplicationDbContext _db; 
    public IProjectRepository projects { get; private set;}
    public ITaskRepository tasks { get; private set; }

    public UnitOfWork(ApplicationDbContext db){
        _db = db;
        projects = new ProjectRepository(db);
        tasks = new TaskRepository(db);
    }

    public void Save (){
        _db.SaveChanges();
    }
}
