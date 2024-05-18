using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;
using iTask.Data;

public class TaskRepository : Repository<Task>, ITaskRepository
{
    public ApplicationDbContext _db; 
    public TaskRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
}