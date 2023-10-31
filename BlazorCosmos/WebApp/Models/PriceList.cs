namespace BlazorWebApp.Models
{
    public class PriceList
    {
        public Guid Id { get; set; }
        public List<Reservation>? Reservations { get; set; }
        public DateTimeOffset ValidUntil { get; set; }
        public ICollection<RouteInfo>? Legs { get; set; }
    }
}
