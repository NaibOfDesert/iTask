using iTask.Data;

public class TaskRepository : ITaskRepository
{
    public ApplicationDbContext _db; 
    public TaskRepository(ApplicationDbContext db)
    {

    }
}