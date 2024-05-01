namespace Yuu.Pratice.API.Models.TouristRoutes;

public class TouristRoute
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal OriginalPrice { get; set; }
    public double? DiscountPersent { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
    public DateTime? DepartureTime { get; set; }
    public string Features { get; set; } = string.Empty;
    public string Fees { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; } = [];
}
