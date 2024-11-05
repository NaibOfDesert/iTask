using System.ComponentModel.DataAnnotations;

public class Assignment
{
    [Key]
    public int Id { get; set; }
    public int? IdProject{ get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = "Task";
    public string? Description { get; set; }
    [Required]
    public AssignmentStatus AssignmentStatus{ get; set; } = AssignmentStatus.ToDo; 
    [Required]
    
    public DateTime DateStart { get; set; } = DateTime.Today;
    [Required]
    public DateTime DateEnd { get; set;} = DateTime.Today.AddDays(7);
}