namespace JolpicaApi.Serialization.Converters
{
    /// <summary>
    /// Converts a TimeSpan to and from a string representation with a gap format.
    /// </summary>
    public class StringGapTimeSpanConverter : StringTimeSpanConverter
    {
        /// <summary>
        /// Gets the array of formats used for parsing and formatting TimeSpan values.
        /// </summary>
        protected override string[] Formats =>
        [
                "'+'mm':'ss'.'fff",
                "'+'m':'ss'.'fff",
                "'+'ss'.'fff",
                "'+'s'.'fff",
            ];
    }
}
