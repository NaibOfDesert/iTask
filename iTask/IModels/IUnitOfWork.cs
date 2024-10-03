public interface IUnitOfWork
{
    public IProjectRepository projects {get;}
    public ITaskRepository tasks {get;}
}