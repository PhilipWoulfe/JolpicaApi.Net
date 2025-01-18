using System.Collections.Generic;
using JolpiApi.Responses.Models;

namespace JolpiApi.Responses
{
    public class FinishingStatusResponse : ErgastResponse
    {
        [JsonPathProperty("StatusTable.Status")]
        public IList<FinishingStatus> Statuses { get; private set; }
    }
}
