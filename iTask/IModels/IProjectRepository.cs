public interface IProjectRepository : IRepository<Project>
{
    public void AddAssignment(Project project, Assignment assignment);
    public void RemoveAssignment(Project project, Assignment assignment);
}