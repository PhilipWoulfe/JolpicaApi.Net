using System.Collections.Generic;
using JolpicaApi.Responses.Models;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses
{
    public class FinishingStatusResponse : JolpicaResponse
    {
        [JsonPathProperty("StatusTable.Status")]
        public IList<FinishingStatus> Statuses { get; private set; }
    }
}
