using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp.Models
{
    public class Provider
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
        public Guid RouteInfoId { get; set; }
        public RouteInfo? RouteInfo { get; set; }

        public ICollection<FlightRoute>? Flights { get; set; } = new HashSet<FlightRoute>();

        [DisplayFormat(DataFormatString = "{0:N2}")]

        public decimal Price { get; set; }
        public DateTimeOffset FlightStart { get; set; }
        public DateTimeOffset FlightEnd { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan TravelTime { get; set; }
    }
}
