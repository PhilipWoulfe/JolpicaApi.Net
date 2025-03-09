using System;
using JolpicaApi.Serialization.Converters;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents the timing information for a lap in a race.
    /// </summary>
    public class LapTiming
    {
        /// <summary>
        /// Gets the ID of the driver.
        /// </summary>
        [JsonProperty("driverId")]
        public string DriverId { get; private set; }

        /// <summary>
        /// Gets the position of the driver in the lap.
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; private set; }

        /// <summary>
        /// Gets the time taken for the lap.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? Time { get; private set; }
    }
}