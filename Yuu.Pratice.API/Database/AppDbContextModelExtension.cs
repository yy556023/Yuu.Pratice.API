using Microsoft.EntityFrameworkCore;
using Yuu.Pratice.API.Models.TouristRoutes;

namespace Yuu.Pratice.API.Database;

public static class AppDbContextModelExtension
{
    public static void ConfigureTouristRoute(this ModelBuilder builder)
    {

        #region TouristRoute
        builder.Entity<TouristRoute>(e =>
        {
            e.HasKey(x => x.Id);
            e.Property(p => p.Title).HasMaxLength(100).IsRequired();
            e.Property(p => p.Description).HasMaxLength(1500).IsRequired();
            e.Property(p => p.OriginalPrice).HasColumnType("decimal(18, 2)");
            e.Property(p => p.DiscountPersent);
            e.Property(p => p.Features);
            e.Property(p => p.Fees);
            e.Property(p => p.Notes);
        });
        #endregion

        #region TouristRoutePicture
        builder.Entity<TouristRoutePicture>(e =>
        {
            e.HasKey(x => x.Id);

            e.Property(p => p.Id).UseIdentityColumn();
            e.Property(p => p.Url).HasMaxLength(100);
            e.HasOne(p => p.TouristRoute).WithMany(f => f.TouristRoutePictures).HasForeignKey(p => p.TouristRouteId);
        });
        #endregion

    }
}
