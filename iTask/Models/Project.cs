using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Project
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    [Required]
    public DateTime DateStart { get; set; } = DateTime.Now;
    [Required]
    public DateTime DateEnd { get; set; } = DateTime.Now.AddDays(20);
    public List<Assignment> Assignments{ get; set; } = new List<Assignment>();
    // Manager / Owner
    // UsersList

}