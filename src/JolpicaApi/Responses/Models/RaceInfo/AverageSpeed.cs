using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents the average speed with its unit.
    /// </summary>
    public class AverageSpeed
    {
        /// <summary>
        /// Gets the unit of speed.
        /// </summary>
        [JsonProperty("units")]
        public SpeedUnit Unit { get; private set; }

        /// <summary>
        /// Gets the speed value.
        /// </summary>
        [JsonProperty("speed")]
        public double Speed { get; private set; }
    }
}