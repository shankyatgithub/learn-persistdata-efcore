using ContosoPizza.Models;

namespace ContosoPizza.Data;
public static class DbIntializer
{
    public static void Initialize(PizzaDbContext context)
    {
        if(context.Pizzas.Any() && context.Sauces.Any() && context.Toppings.Any())
        {
            return; //DB is seeded
        }

        var pepperoniTopping = new Topping { Name = "Pepperoni", Calories = 130 };
        var sausageTopping = new Topping {Name = "Sauage", Calories = 100};
        var hamTopping = new Topping {Name = "Ham", Calories = 70};
        var chickenTopping = new Topping {Name = "Chicken", Calories = 50};
        var pineappleTopping = new Topping { Name = "Pipeapple", Calories = 75 };

        var tomatoSauce = new Sauce {Name = "Tomato", IsVegan = true};
        var alfredoSauce = new Sauce {Name="Alfredo", IsVegan = true};

        var pizzas = new Pizza[]{
            new Pizza{
                Name = "Meat lovers",
                Sauce = tomatoSauce,
                Toppings = new List<Topping>{
                    pepperoniTopping,
                    sausageTopping,
                    hamTopping,
                    chickenTopping
                }
            },
            new Pizza{
                Name = "Hawaiian",
                Sauce = tomatoSauce,
                Toppings = new List<Topping>{
                    pineappleTopping,
                    hamTopping
                }
            },
            new Pizza{
                Name = "Alfredo Chicken",
                Sauce = alfredoSauce,
                Toppings = new List<Topping>
                {
                    chickenTopping
                }
            }
        };

        context.Pizzas.AddRange(pizzas);
        context.SaveChanges();

    }
}