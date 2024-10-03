using iTask.Data;
using Microsoft.EntityFrameworkCore;

public class TaskRepository : Repository<Task>, ITaskRepository
{
    private readonly ApplicationDbContext _db;
    public TaskRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
}