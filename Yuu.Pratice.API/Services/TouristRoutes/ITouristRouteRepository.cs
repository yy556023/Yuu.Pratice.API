using Yuu.Pratice.API.Models.TouristRoutes;

namespace Yuu.Pratice.API.Services.TouristRoutes;

public interface ITouristRouteRepository
{
    Task<IList<TouristRoute>> GetTouristRoutes(string keyword, string operatorType, int ratingValue);
    Task<TouristRoute> GetTouristRoute(Guid touristRouteId);
    Task<bool> TouristRouteExist(Guid touristRouteId);
    Task<IList<TouristRoutePicture>> GetTouristRoutePictures(Guid touristRouteId);
    Task<TouristRoutePicture> GetTouristRoutePicture(int pictureId);
}
