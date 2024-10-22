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
    public DateTime DateStart { get; set; } = DateTime.Now;
    [Required]
    public DateTime DateEnd { get; set;} = DateTime.Now.AddDays(7);
}