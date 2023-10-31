using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(64)]
        [StringLength(64, MinimumLength = 1)]
        public string Name { get; set; } = default!;

        public ICollection<Provider>? Providers { get; set; }
    }
}
