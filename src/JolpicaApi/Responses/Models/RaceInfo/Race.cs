using System;
using System.Globalization;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents a race with details such as season, round, race name, URL, circuit, and start time.
    /// </summary>
    public class Race
    {
        /// <summary>
        /// Gets the season of the race.
        /// </summary>
        [JsonProperty("season")]
        public int Season { get; private set; }

        /// <summary>
        /// Gets the round of the race.
        /// </summary>
        [JsonProperty("round")]
        public int Round { get; private set; }

        /// <summary>
        /// Gets the name of the race.
        /// </summary>
        [JsonProperty("raceName")]
        public string RaceName { get; private set; }

        /// <summary>
        /// Gets the Wikipedia URL of the race.
        /// </summary>
        [JsonProperty("url")]
        public string WikiUrl { get; private set; }

        /// <summary>
        /// Gets the circuit details of the race.
        /// </summary>
        [JsonProperty("circuit")]
        public Circuit Circuit { get; private set; }

        /// <summary>
        /// Gets the start time of the race.
        /// </summary>
        public DateTime StartTime => DateTime.Parse(DateRaw + " " + TimeRaw, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// Gets the raw date of the race.
        /// </summary>
        [JsonProperty("date")]
        internal string DateRaw { get; private set; }

        /// <summary>
        /// Gets the raw time of the race.
        /// </summary>
        [JsonProperty("time")]
        internal string TimeRaw { get; private set; }
    }
}
