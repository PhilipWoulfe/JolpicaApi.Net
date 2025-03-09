namespace JolpicaApi.Responses.Models.Standings
{
    /// <summary>
    /// Represents the standing of a constructor in a racing event.
    /// </summary>
    public class ConstructorStanding : Standing
    {
        /// <summary>
        /// Gets or sets the constructor details.
        /// </summary>
        public Constructor Constructor { get; set; }
    }
}