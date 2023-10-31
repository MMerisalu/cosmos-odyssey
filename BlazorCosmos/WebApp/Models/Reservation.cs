using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp.Models
{
    public class Reservation
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(64)]
        [StringLength(64, MinimumLength = 1)]
        public string FirstName { get; set; } = default!;

        [Required]
        [MaxLength(64)]
        [StringLength(64, MinimumLength = 1)]
        public string LastName { get; set; } = default!;

        public string FirstAndLastName => $"{FirstName} {LastName}";
        public string LastAndFirstName => $"{LastName} {FirstName}";

        [Required]

        public string From { get; set; } = default!;

        [Required]
        public string? To { get; set; }

        public ICollection<FlightRoute> Routes { get; set; } = new HashSet<FlightRoute>();

        public Guid PriceListId { get; set; }
        public PriceList? PriceList { get; set; }
        public decimal TotalPrice { get; set; }

        public TimeSpan TotalFlightTime { get; set; }

        public string? Companies { get; set; }

    }
}
