using Yuu.Pratice.API.Models.TouristRoutes;

namespace Yuu.Pratice.API.Services.TouristRoutes;

public interface ITouristRouteRepository
{
    IEnumerable<TouristRoute> GetTouristRoutes();
    TouristRoute GetTouristRoute(Guid touristRouteId);
}
