using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Project
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    [Required]
    public DateTime DateStart { get; set; } = DateTime.Today;
    [Required]
    public DateTime DateEnd { get; set; } = DateTime.Today.AddDays(20);
    public List<Assignment> Assignments{ get; set; } = new List<Assignment>();
    public string? Description { get; set; }
}