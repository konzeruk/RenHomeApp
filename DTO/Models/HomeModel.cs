using Newtonsoft.Json;

namespace DTO.Models
{
    public sealed class HomeModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("reservations")]
        public List<ReservationModel>? Reservations { get; set; }
    }
}
