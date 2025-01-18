using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models
{
    public class Season
    {
        [JsonProperty("season")]
        public int Year { get; private set; }

        [JsonProperty("url")]
        public string WikiUrl { get; private set; }
    }
}
