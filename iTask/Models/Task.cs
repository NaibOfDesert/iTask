using System.ComponentModel.DataAnnotations;

public class Task
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = "Task";
    public string Description { get; set; } = "";
    [Required]
    public TaskStatus taskStatus{ get; set; } = TaskStatus.ToDo; 
    [Required]
    public DateTime dateStart { get; set; } = DateTime.Now;
    [Required]
    public DateTime dateEnd { get; set;} = DateTime.Now.AddDays(7);
    [Required]
    public Project? projectAffiliation { get; set; } = null;
}