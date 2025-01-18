using System.Collections.Generic;
using JolpiApi.Responses.Models;
using JolpiApi.Serialization;

namespace JolpiApi.Responses
{
    public class FinishingStatusResponse : JolpiResponse
    {
        [JsonPathProperty("StatusTable.Status")]
        public IList<FinishingStatus> Statuses { get; private set; }
    }
}
