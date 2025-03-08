using JolpicaApi.Serialization;
using System.Collections.Generic;

namespace JolpicaApi.Responses.Standings
{
    public abstract class StandingsResponse<T> : JolpicaResponse
    {
        [JsonPathProperty("StandingsTable.StandingsLists")]
        public IList<T> StandingsLists { get; private set; }
    }
}
