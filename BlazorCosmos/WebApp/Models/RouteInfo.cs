using System.Text.Json.Serialization;

namespace BlazorWebApp.Models
{
    public class RouteInfo
    {
        public Guid Id { get; set; }
        
        public Guid FromId { get; set; }
        public string From { get; set; } = default!;

        public Guid ToId { get; set; }
        public string? To { get; set; }

        public int Distance { get; set; }

        public ICollection<Provider>? Providers { get; set; }

        public Guid PriceListId { get; set; }
        public PriceList? PriceList { get; set; }
    }
}
