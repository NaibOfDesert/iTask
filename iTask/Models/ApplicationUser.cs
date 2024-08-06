using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser{
    [PersonalData] 
    public string? Name { get; set; }
}