using System.Collections.Generic;
using JolpicaApi.Responses.Models.RaceInfo;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses.RaceInfo
{
    public abstract class RaceResponse<T> : JolpiResponse where T : Race
    {
        [JsonPathProperty("RaceTable.Races")]
        public IList<T> Races { get; set; }
    }
}
