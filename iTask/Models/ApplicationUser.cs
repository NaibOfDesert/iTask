using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    [PersonalData] 
    public string? Name { get; set; }
    public override string?  Email { get; set; }
    public override string?  PasswordHash { get; set; }

    
}