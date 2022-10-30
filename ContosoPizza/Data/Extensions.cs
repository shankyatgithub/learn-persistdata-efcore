namespace ContosoPizza.Data;
public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        {
            using(var scope = host.Services.CreateScope())
            {
                var service = scope.ServiceProvider;
                var context = service.GetRequiredService<PizzaDbContext>();
                context.Database.EnsureCreated();
                DbIntializer.Initialize(context);
            }
        }
    }
}
