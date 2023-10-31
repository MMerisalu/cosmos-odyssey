using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebApp.Models
{
    public class FlightRoute
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Reservation))]
        public Guid ReservationId { get; set; }
        public Reservation? Reservation { get; set; }

        [ForeignKey(nameof(Provider))]
        public Guid ProviderId { get; set; }
        public Provider? Provider { get; set; }


    }
}
