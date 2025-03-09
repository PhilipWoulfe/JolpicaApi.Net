using System;
using System.Text.RegularExpressions;

namespace JolpicaApi.Responses.Models
{
    /// <summary>
    /// Provides methods to parse finishing status IDs from strings.
    /// </summary>
    public static partial class FinishingStatusIdParser
    {
#if NET8_0_OR_GREATER
        [GeneratedRegex(@"\+(\d+) Laps?", RegexOptions.IgnoreCase)]
        private static partial Regex LapsRegex();

        [GeneratedRegex(@"\s")]
        private static partial Regex SpaceRegex();
#else
            private static Regex LapsRegex() => new(@"\+(\d+) Laps?", RegexOptions.IgnoreCase);
            private static Regex SpaceRegex() => new(@"\s");
#endif

        /// <summary>
        /// Parses a string to a <see cref="FinishingStatusId"/>.
        /// </summary>
        /// <param name="value">The string value to parse.</param>
        /// <returns>The parsed <see cref="FinishingStatusId"/>.</returns>
        public static FinishingStatusId Parse(string value)
        {
            FinishingStatusId statusId;

            var lapsMatch = LapsRegex().Match(value);
            if (lapsMatch.Success)
            {
                value = "Laps" + lapsMatch.Groups[1].Value;
                if (Enum.TryParse(value, out statusId))
                    return statusId;
            }

            value = SpaceRegex().Replace(value, "");

            Enum.TryParse(value, true, out statusId);

            return statusId;
        }
    }
}