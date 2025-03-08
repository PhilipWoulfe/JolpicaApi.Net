using System.Collections.Generic;
using JolpicaApi.Responses.Models;

using JolpicaApi.Serialization;
namespace JolpicaApi.Responses
{
    public class SeasonResponse : JolpicaResponse
    {
        [JsonPathProperty("SeasonTable.Seasons")]
        public IList<Season> Seasons { get; private set; }
    }
}
