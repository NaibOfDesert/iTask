
using iTask.Data;
public class UnitOfWork : IUnitOfWork
{
    public ApplicationDbContext _db; 
    public IAssignmentRepository assignments { get; private set;}

    public UnitOfWork(ApplicationDbContext db){
        _db = db;
        assignments = new AssignmentRepository(db);  
    }
}