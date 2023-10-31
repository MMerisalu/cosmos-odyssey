using System.Net.Http.Json;
using BlazorWebApp.DTO;
using BlazorWebApp.Models;

namespace BlazorWebApp.Services
{
    public interface ICosmosService
    {
        Task<IEnumerable<PriceListDTO>?> GetAllPricelists();
        Task<IEnumerable<ReservationDTO>?> GetAllReservations();
        Task<PriceListDTO?> RefreshPriceLists();
        Task<List<string>?> GetAllOrigins(Guid priceListId);
        Task<IEnumerable<FlightRouteDTO>?> GetLegsFromOrigin(Guid priceListId, string from);
        Task<ReservationDTO?> GetReservationById(Guid id);
        Task DeleteReservation(Guid id);
        Task<ReservationDTO?> ReservationSearch(Guid reservationId, string lastName);
        Task SubmitReservation(ReservationDTO reservation);

    }
    public class CosmosService : MVCBaseService, ICosmosService
    {
  
        public CosmosService(HttpClient httpClient)
            : base(httpClient)
        {
          
        }

        
        public async Task<IEnumerable<PriceListDTO>?> GetAllPricelists()
        {
            return await Client.GetFromJsonAsync<IEnumerable<PriceListDTO>>($"api/PriceLists");
        }

        public async Task<IEnumerable<ReservationDTO>?> GetAllReservations()
        {
            return await Client.GetFromJsonAsync<IEnumerable<ReservationDTO>>($"api/Reservations");
        }

        public async Task<PriceListDTO?> RefreshPriceLists()
        {
            return await Client.GetFromJsonAsync<PriceListDTO>($"api/PriceLists/Refresh");
        }
        public async Task<List<string>?> GetAllOrigins(Guid priceListId)
        {
            return (await Client.GetFromJsonAsync<IEnumerable<string>>($"api/PriceLists/{priceListId}/GetAllOrigins")).ToList();
        }
        public async Task<IEnumerable<FlightRouteDTO>?> GetLegsFromOrigin(Guid priceListId, string from)
        {
            return await Client.GetFromJsonAsync<FlightRouteDTO[]>($"api/PriceLists/{priceListId}/GetLegs/{from}");
        }

        public async Task<ReservationDTO?> GetReservationById(Guid id)
        {
            return await Client.GetFromJsonAsync<ReservationDTO?>($"api/reservations/{id}");
        }

        public async Task SubmitReservation(ReservationDTO reservation)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(reservation);
            Console.WriteLine(json);
            var result = await Client.PostAsJsonAsync($"api/reservations", reservation);
            result.EnsureSuccessStatusCode();
        }

        public async Task DeleteReservation(Guid id)
        {
            await Client.DeleteAsync($"api/Reservations/{id}");
        }

        public async Task<ReservationDTO?> ReservationSearch(Guid reservationId, string lastName)
        {
           return await Client.GetFromJsonAsync<ReservationDTO?>($"api/Reservations/LookUp?id={reservationId}&lastName={lastName}");
        }
    }
}
