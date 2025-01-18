using System;
using JolpicaApi.Serialization.Converters;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    public class PitStopInfo
    {
        [JsonProperty("driverId")]
        public string DriverId { get; private set; }

        [JsonProperty("lap")]
        public int Lap { get; private set; }

        [JsonProperty("stop")]
        public int Stop { get; private set; }

        [JsonProperty("time")]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan TimeOfDay { get; private set; }

        [JsonProperty("duration")]
        [JsonConverter(typeof(SecondsTimeSpanConverter))]
        public TimeSpan Duration { get; private set; }
    }
}