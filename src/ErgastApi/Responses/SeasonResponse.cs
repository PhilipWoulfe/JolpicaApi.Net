using System.Collections.Generic;
using JolpiApi.Responses.Models;

namespace JolpiApi.Responses
{
    public class SeasonResponse : ErgastResponse
    {
        [JsonPathProperty("SeasonTable.Seasons")]
        public IList<Season> Seasons { get; private set; }
    }
}
