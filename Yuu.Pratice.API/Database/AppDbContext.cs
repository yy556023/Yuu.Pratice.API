using Microsoft.EntityFrameworkCore;
using Yuu.Pratice.API.Models.TouristRoutes;

namespace Yuu.Pratice.API.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<TouristRoute> TouristRoutes { get; set; }
    public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureTouristRoute();
    }
}
