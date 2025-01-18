using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    public abstract class ResultBase
    {
        [JsonProperty("number")]
        public int Number { get; private set; }

        [JsonProperty("position")]
        public int Position { get; private set; }

        [JsonProperty(nameof(Driver))]
        public Driver Driver { get; private set; }

        [JsonProperty(nameof(Constructor))]
        public Constructor Constructor { get; private set; }
    }
}