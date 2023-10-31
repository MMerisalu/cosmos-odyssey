using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorWebApp.DTO
{
    public class ReservationDTO
    {
        public string Id { get; set; }
        [Required]
        [MaxLength(64)]
        [StringLength(64, MinimumLength = 1)]
        public string FirstName { get; set; } = default!;

        [Required]
        [MaxLength(64)]
        [StringLength(64, MinimumLength = 1)]
        public string LastName { get; set; } = default!;



        [Required]

        public string From { get; set; } = default!;

        [Required]
        public string? To { get; set; }

        public ICollection<FlightRouteDTO> Routes { get; set; } = new HashSet<FlightRouteDTO>();

        public Guid PriceListId { get; set; }
        public decimal? TotalQuotedPrice { get; set; }
        public long TotalDistance { get; set; }
        public TimeSpan? TotalTravelTime { get; set; }
        public string? CompanyNames { get; set; } = default!;
        public string? LayOvers { get; set; } = default!;

        #region Formatting Helpers

        public string FormattedTotalTravelTime { get => TotalTravelTime.HasValue ? $"{TotalTravelTime.Value.Days} days, {TotalTravelTime.Value.Hours} hours, {TotalTravelTime.Value.Minutes} minutes" : String.Empty; }

        #endregion Formatting Helpers
    }
}
