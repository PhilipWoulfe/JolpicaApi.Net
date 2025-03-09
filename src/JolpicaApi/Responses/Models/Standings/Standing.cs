namespace JolpicaApi.Responses.Models.Standings
{
    /// <summary>
    /// Represents a standing in a competition.
    /// </summary>
    public abstract class Standing
    {
        /// <summary>
        /// Gets or sets the position in the standings.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Finishing position.
        /// R = Retired, D = Disqualified, E = Excluded, W = Withdrawn, F = Failed to qualify, N = Not classified.
        /// </summary>
        public string PositionText { get; set; }

        /// <summary>
        /// Gets or sets the points earned.
        /// </summary>
        public double Points { get; set; }

        /// <summary>
        /// Gets or sets the number of wins.
        /// </summary>
        public int Wins { get; set; }
    }
}