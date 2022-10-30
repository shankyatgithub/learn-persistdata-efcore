using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoPizza.Data;
public class ToppingsEntityConfiguration : IEntityTypeConfiguration<Models.Topping>
{

    public void Configure(EntityTypeBuilder<Topping> builder)
    {
        builder.Property(t => t.Name)
        .IsRequired()
        .HasMaxLength(100);
    }
}