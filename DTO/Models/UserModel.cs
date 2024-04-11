using Newtonsoft.Json;

namespace DTO.Models
{
    public class UserModel
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
