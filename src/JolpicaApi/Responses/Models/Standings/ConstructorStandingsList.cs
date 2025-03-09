using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.Standings
{
    /// <summary>
    /// Represents a list of constructor standings for a specific season and round.
    /// </summary>
    public class ConstructorStandingsList : StandingsList<ConstructorStanding>
    {
        /// <summary>
        /// Gets or sets the list of constructor standings.
        /// </summary>
        [JsonProperty("ConstructorStandings")]
        public override IList<ConstructorStanding> Standings { get; set; }
    }
}