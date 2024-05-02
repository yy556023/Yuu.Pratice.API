using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Yuu.Pratice.API.Dtos.TouristRoutes;
using Yuu.Pratice.API.Models.TouristRoutes;

namespace Yuu.Pratice.API.Profiles.TouristRoutes;
public class TouristRoutePictureProfile : Profile
{
    public TouristRoutePictureProfile()
    {
        CreateMap<TouristRoutePicture, TouristRoutePictureDto>();
    }
}