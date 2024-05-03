using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yuu.Pratice.API.Dtos.TouristRoutes;
using Yuu.Pratice.API.Services.TouristRoutes;

namespace Yuu.Pratice.API.Controllers.TouristRoutes
{
    [Route("api/touristRoutes/{touristRouteId}/picture")]
    [ApiController]
    public class TouristRoutePicturesController(
        ITouristRouteRepository touristRouteRepository,
        IMapper mapper,
        ILogger<TouristRoutePicturesController> logger
        ) : ControllerBase
    {
        private readonly ITouristRouteRepository _touristRouteRepository = touristRouteRepository;
        private readonly IMapper _mapper = mapper;
        private readonly ILogger<TouristRoutePicturesController> _logger = logger;

        [HttpGet]
        public async Task<IActionResult> GetTouristRoutePictures(Guid touristRouteId)
        {
            if (!await _touristRouteRepository.TouristRouteExist(touristRouteId))
            {
                return NotFound();
            }

            var pictures = await _touristRouteRepository.GetTouristRoutePictures(touristRouteId);

            if (pictures == null || pictures.Count == 0)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IList<TouristRoutePictureDto>>(pictures));
        }

        [HttpGet("{pictureId}")]
        public async Task<IActionResult> GetPicture(Guid touristRouteId, int pictureId)
        {
            if (!await _touristRouteRepository.TouristRouteExist(touristRouteId))
            {
                return NotFound();
            }

            var picture = await _touristRouteRepository.GetTouristRoutePicture(pictureId);

            if (picture == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TouristRoutePictureDto>(picture));
        }
    }
}