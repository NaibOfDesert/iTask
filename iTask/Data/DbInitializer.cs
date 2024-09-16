using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using iTask.Data;

public class DbInitializer : IDbInitializer
{ 
    public static void Initialize(ApplicationDbContext db)
    {
        try
        {
            if(db.Database.GetPendingMigrations().Count() > 0)
            {
                db.Database.Migrate();
            }
        }
        catch (Exception) { }


    }


}