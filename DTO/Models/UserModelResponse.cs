using Newtonsoft.Json;

namespace DTO.Models
{
    public sealed class UserModelResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }
    }
}
