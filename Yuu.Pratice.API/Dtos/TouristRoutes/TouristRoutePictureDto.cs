using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yuu.Pratice.API.Dtos.TouristRoutes
{
    public class TouristRoutePictureDto
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public Guid TouristRouteId { get; set; }
    }
}