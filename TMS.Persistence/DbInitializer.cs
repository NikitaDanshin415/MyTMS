namespace TMS.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(TmsDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}