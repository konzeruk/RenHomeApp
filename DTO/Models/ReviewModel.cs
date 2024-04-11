using Newtonsoft.Json;

namespace DTO.Models
{
    public sealed class ReviewModel
    {
        [JsonProperty("login")]
        public string Login { get; set; }
        
        [JsonProperty("id_home")]
        public int IdHome { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("grade")]
        public int Grade { get; set; }
    }
}
