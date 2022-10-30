using System.Text.Json.Serialization;

namespace ContosoPizza.Models;

public class Topping
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Calories { get; set; }
    
    [JsonIgnore]
    public ICollection<Pizza>? Pizzas { get; set; }
}