using Microsoft.EntityFrameworkCore;
using Yuu.Pratice.API.Database;
using Yuu.Pratice.API.Models.TouristRoutes;

namespace Yuu.Pratice.API.Services.TouristRoutes;

public class TouristRouteRepository(AppDbContext context) : ITouristRouteRepository
{
    private readonly AppDbContext _context = context;

    public async Task<IList<TouristRoute>> GetTouristRoutes()
    {
        return await _context.TouristRoutes.ToListAsync();
    }

    public async Task<TouristRoute> GetTouristRoute(Guid touristRouteId)
    {
        return (await _context.TouristRoutes.FindAsync(touristRouteId))!;
    }

    public async Task<bool> TouristRouteExist(Guid touristRouteId)
    {
        return await _context.TouristRoutes.AnyAsync(e => e.Id == touristRouteId)!;
    }

    public async Task<IList<TouristRoutePicture>> GetTouristRoutePictures(Guid touristRouteId)
    {
        return await _context.TouristRoutePictures
                    .Where(e => e.TouristRouteId == touristRouteId)
                    .ToListAsync();
    }
}
