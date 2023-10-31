using BlazorWebApp.Models;

namespace BlazorWebApp.DTO
{
    public class PriceListDTO
    {
        public Guid Id { get; set; }
        public int NumberOfReservation { get; set; }
        public string ValidUntil { get; set; } = default!;
        public int NumberOfLegs { get; set; }
    }
}
