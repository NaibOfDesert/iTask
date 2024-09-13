using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;
using iTask.Data;

public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
{
    public ApplicationDbContext _db; 
    public AssignmentRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
}