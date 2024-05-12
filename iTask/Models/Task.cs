using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Task {
    [Key]
    public int Id {get; set;} 
}