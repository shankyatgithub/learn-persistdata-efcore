using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoPizza.Data;

public class SauceEntityConfiguration : IEntityTypeConfiguration<Sauce>
{
    public void Configure(EntityTypeBuilder<Sauce> builder)
    {
        builder.Property(s => s.Name)
        .IsRequired()
        .HasMaxLength(100);
    }
}
