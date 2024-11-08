public class AssignmentCard{
    public Assignment Assignment { get; set; } 
    public List<AssignmentStatus> AssignmentStatusList = new List<AssignmentStatus> { 
        AssignmentStatus.ToDo, 
        AssignmentStatus.InProgress, 
        AssignmentStatus.Done
    }; 

    public AssignmentCard(Assignment assignment){
        this.Assignment = assignment;
    }
}



