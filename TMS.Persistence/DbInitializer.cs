using Microsoft.EntityFrameworkCore;

namespace TMS.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(TmsDbContext context)
        {
             context.Database.Migrate();
            //context.Database.EnsureCreated();
        }
    }
}