public interface ITaskRepository : IRepository<Task>
{
    void Update(Task task);

}