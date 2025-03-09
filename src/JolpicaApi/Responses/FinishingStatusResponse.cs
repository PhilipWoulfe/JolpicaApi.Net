using System.Collections.Generic;
using JolpicaApi.Responses.Models;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses
{
    /// <summary>
    /// Represents the response containing finishing statuses.
    /// </summary>
    public class FinishingStatusResponse : JolpicaResponse
    {
        /// <summary>
        /// Gets the list of finishing statuses.
        /// </summary>
        [JsonPathProperty("StatusTable.Status")]
        public IList<FinishingStatus> Statuses { get; private set; }
    }
}
