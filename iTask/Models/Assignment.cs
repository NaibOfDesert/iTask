using System.ComponentModel.DataAnnotations;

public class Assignment
{
    [Key]
    public int Id { get; set; }
    public int? IdProject{ get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = "Task";
    public string Description { get; set; } = "";
    [Required]
    public AssignmentStatus assignmentStatus{ get; set; } = AssignmentStatus.ToDo; 
    [Required]
    public DateTime dateStart { get; set; } = DateTime.Now;
    [Required]
    public DateTime dateEnd { get; set;} = DateTime.Now.AddDays(7);
}