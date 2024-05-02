using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yuu.Pratice.API.Dtos.TouristRoutes;
public class TouristRouteDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    // public decimal OriginalPrice { get; set; }
    // public double? DiscountPersent { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
    public DateTime? DepartureTime { get; set; }
    public string Features { get; set; } = string.Empty;
    public string Fees { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public double? Rating { get; set; }
    public string TravelDays { get; set; } = string.Empty;
    public string TripType { get; set; } = string.Empty;
    public string DepartureCity { get; set; } = string.Empty;
}