using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class AppUser: IdentityUser{
    public string Name { get; set;}
    
}