using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models
{
    /// <summary>
    /// Represents the finishing status of an entity.
    /// </summary>
    public class FinishingStatus
    {
        /// <summary>
        /// Gets the status identifier.
        /// </summary>
        [JsonProperty("statusId")]
        public FinishingStatusId Status { get; private set; }

        /// <summary>
        /// Gets the count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; private set; }

        /// <summary>
        /// Gets the status text.
        /// </summary>
        [JsonProperty("status")]
        public string StatusText { get; private set; }
    }
}
