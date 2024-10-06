using iTask.Data;
using Microsoft.EntityFrameworkCore;

public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
{
    private readonly ApplicationDbContext _db;
    public AssignmentRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    
}