using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yuu.Pratice.API.Dtos.TouristRoutes;
using Yuu.Pratice.API.Services.TouristRoutes;

namespace Yuu.Pratice.API.Controllers.TouristRoutes
{
    [Route("api/touristRoutes")]
    [ApiController]
    public class TouristRoutesController(
        ITouristRouteRepository touristRouteRepository,
        IMapper mapper,
        ILogger<TouristRoutesController> logger
    ) : ControllerBase
    {
        private readonly ITouristRouteRepository _touristRouteRepository = touristRouteRepository;
        private readonly IMapper _mapper = mapper;
        private readonly ILogger<TouristRoutesController> _logger = logger;

        [HttpGet]
        [HttpHead]
        public async Task<IActionResult> GetTouristRoutes(
            [FromQuery] string keyword,
            string rating
        )
        {
            var regex = new Regex(@"([A-Za-z0-9\-]+)(\d+)");
            var operatorType = string.Empty;
            var ratingValue = 0;
            var match = regex.Match(rating);

            if (match.Success)
            {
                operatorType = match.Groups[1].Value;
                ratingValue = int.Parse(match.Groups[2].Value);
            }

            var routes = await _touristRouteRepository.GetTouristRoutes(keyword, operatorType, ratingValue);

            if (routes == null || routes.Count == 0)
            {
                return NotFound();
            }

            var routesDto = _mapper.Map<IEnumerable<TouristRouteDto>>(routes);

            return Ok(routesDto);
        }

        [HttpGet("{touristRouteId:Guid}")]
        [HttpHead]
        public async Task<IActionResult> GetTouristRouteById(Guid touristRouteId)
        {
            var route = await _touristRouteRepository.GetTouristRoute(touristRouteId);

            if (route == null)
            {
                return NotFound();
            }

            var routeDto = _mapper.Map<TouristRouteDto>(route);

            return Ok(routeDto);
        }
    }
}