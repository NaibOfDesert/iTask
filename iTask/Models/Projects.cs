using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Project
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    DateTime  DateStart { get; set; }
    DateTime  DateEnd { get; set; }
    
    // Tast List
    // Manager
    // UsersList
    



}