
public class ProjectCard{
    private IEnumerable<Assignment> enumerable;

    public Project Project { get; set; }
    public List<Assignment> Assignments { get; set; }

    public ProjectCard (Project project, List<Assignment> assignments){
        this.Project = project;
        this.Assignments = assignments;
    }
}