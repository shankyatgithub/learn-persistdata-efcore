
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoPizza.Data
{
    public class PizzaEntityConfiguration : IEntityTypeConfiguration<Models.Pizza>
    {
        void Configure(EntityTypeBuilder<Pizza> builder)
        {

        }

        void IEntityTypeConfiguration<Pizza>.Configure(EntityTypeBuilder<Pizza> builder)
        {
         
            builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);
        }
    }
}