using JolpiApi.Serialization;
using System.Collections.Generic;

namespace JolpiApi.Responses.Standings
{
    public abstract class StandingsResponse<T> : JolpiResponse
    {
        [JsonPathProperty("StandingsTable.StandingsLists")]
        public IList<T> StandingsLists { get; private set; }
    }
}
