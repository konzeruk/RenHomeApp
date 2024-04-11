using Newtonsoft.Json;

namespace DTO.Models
{
    public sealed class ReservationModel
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }
}
