using System.Collections.Generic;

namespace JolpicaApi.Responses.Models.Standings
{
    /// <summary>
    /// Represents a list of standings for a specific season and round.
    /// </summary>
    /// <typeparam name="T">The type of standing.</typeparam>
    public abstract class StandingsList<T> where T : Standing
    {
        /// <summary>
        /// Gets or sets the season of the standings.
        /// </summary>
        public int Season { get; set; }

        /// <summary>
        /// Gets or sets the round of the standings.
        /// </summary>
        public int Round { get; set; }

        /// <summary>
        /// Gets or sets the list of standings.
        /// </summary>
        public abstract IList<T> Standings { get; set; }
    }
}