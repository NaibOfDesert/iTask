public interface IUnitOfWork
{
    public IProjectRepository projects {get;}
    public IAssignmentRepository assignments {get;}

    public void Save(); 
}