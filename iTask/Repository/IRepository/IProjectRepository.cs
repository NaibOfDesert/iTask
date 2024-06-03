public interface IProjectRepository : IRepository<Project>
{
    public List<Project> GetAll();
}