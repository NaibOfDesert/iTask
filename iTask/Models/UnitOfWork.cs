using iTask.Data;
public class UnitOfWork : IUnitOfWork
{
    public ApplicationDbContext _db; 
    public IProjectRepository projects { get; private set;}
    public IAssignmentRepository assignments { get; private set; }

    public UnitOfWork(ApplicationDbContext db){
        _db = db;
        projects = new ProjectRepository(db);
        assignments = new AssignmentRepository(db);
    }

    public void Save (){
        _db.SaveChanges();
    }
}
