using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data;

public class PizzaDbContext : DbContext
{
    public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) {}

    public DbSet<Pizza> Pizzas => Set<Pizza>();
    public DbSet<Sauce> Sauces => Set<Sauce>();
    public DbSet<Topping> Toppings => Set<Topping>();    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PizzaEntityConfiguration());   
        modelBuilder.ApplyConfiguration(new SauceEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ToppingsEntityConfiguration());
    }
}
