using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using iTask.Data;

public class DbInitializer : IDbInitializer
{ 
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _db; 

    public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager ,RoleManager<IdentityRole> roleManager){
        _db = db;
        _userManager = userManager;
        _roleManager = roleManager;
    }
    public void Initialize()
    {        
        try
        {
            if(_db.Database.GetPendingMigrations().Count() > 0)
            {
                _db.Database.Migrate();
            }
        }
        catch (Exception ex) { }
 
        if(!_roleManager.RoleExistsAsync(Roles.RoleAdmin).GetAwaiter().GetResult()){
            _roleManager.CreateAsync(new IdentityRole(Roles.RoleAdmin)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(Roles.RoleUser)).GetAwaiter().GetResult();

            
        }

        _userManager.CreateAsync(new AppUser{
            UserName = "Admin",
            Email = "admin@admin.com",
            Name = "AdminName AdminLastName"
        }, "Admin1!").GetAwaiter().GetResult(); 


        AppUser user = _db.Users.FirstOrDefault(x => x.UserName == "Admin");
        _userManager.AddToRoleAsync(user, Roles.RoleAdmin).GetAwaiter().GetResult();

        //return;
    }
}