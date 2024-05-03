using Microsoft.EntityFrameworkCore;
using Yuu.Pratice.API.Database;
using Yuu.Pratice.API.Models.TouristRoutes;

namespace Yuu.Pratice.API.Services.TouristRoutes;

public class TouristRouteRepository(AppDbContext context) : ITouristRouteRepository
{
    private readonly AppDbContext _context = context;

    public async Task<IList<TouristRoute>> GetTouristRoutes(string keyword, string operatorType, int ratingValue)
    {
        return await _context.TouristRoutes
        .Where(e => string.IsNullOrEmpty(keyword) || e.Title.Contains(keyword.Trim()))
        .Include(t => t.TouristRoutePictures)
        .ToListAsync();
    }

    public async Task<TouristRoute> GetTouristRoute(Guid touristRouteId)
    {
        return (await _context.TouristRoutes
        .Include(t => t.TouristRoutePictures)
        .FirstOrDefaultAsync(e => e.Id == touristRouteId))!;
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

    public async Task<TouristRoutePicture> GetTouristRoutePicture(int pictureId)
    {
        return (await _context.TouristRoutePictures.FindAsync(pictureId))!;
    }
}
