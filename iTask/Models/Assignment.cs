using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Assignment
{
    [Key]
    public int Id {get; set;} 
    // [Required]
    public AssigmnetsState State {get; set;}
    // [Required]
    public Project Project {get; set;}

}