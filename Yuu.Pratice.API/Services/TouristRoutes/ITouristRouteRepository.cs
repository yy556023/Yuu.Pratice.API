using Yuu.Pratice.API.Models.TouristRoutes;

namespace Yuu.Pratice.API.Services.TouristRoutes;

public interface ITouristRouteRepository
{
    Task<IList<TouristRoute>> GetTouristRoutes();
    Task<TouristRoute> GetTouristRoute(Guid touristRouteId);
    Task<bool> TouristRouteExist(Guid touristRouteId);
    Task<IList<TouristRoutePicture>> GetTouristRoutePictures(Guid touristRouteId);
}
