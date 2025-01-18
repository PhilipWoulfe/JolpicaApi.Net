using System.Collections.Generic;
using JolpiApi.Responses.Models.RaceInfo;

namespace JolpiApi.Responses.RaceInfo
{
    public abstract class RaceResponse<T> : ErgastResponse where T : Race
    {
        [JsonPathProperty("RaceTable.Races")]
        public IList<T> Races { get; private set; }
    }
}
