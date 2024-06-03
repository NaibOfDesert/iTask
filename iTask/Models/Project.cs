using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Project
{
    [Key]
    public int Id { get; set; }

    public IEnumerable <string> AssignmentDone  { get; set; }
    public IEnumerable <string> AssignmentToDo  { get; set; }
    public IEnumerable <string> AssignmentInProgress { get; set; }

}