using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using iTask.Data;

public class DbInitializer : IDbInitializer
{
    private readonly ApplicationDbContext _db; 
    public DbInitializer(ApplicationDbContext db)
    {
        _db = db;
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
        catch (Exception) { }


    }


}