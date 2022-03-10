using Microsoft.EntityFrameworkCore;
using Test_BackEnd.Model;

namespace Test_BackEnd.Data;

public class PlaceContext : DbContext
{
    public PlaceContext(DbContextOptions<PlaceContext> options) : base(options)
    {
    }
    public DbSet<Place> Places { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        

        var place = builder.Entity<Place>();

        place.Property(x => x.Name).IsRequired();
        place.Property(x => x.City).IsRequired();
        place.Property(x => x.State).IsRequired();
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
    {
        configuration.Properties<string>().HaveMaxLength(100);
    }
}
