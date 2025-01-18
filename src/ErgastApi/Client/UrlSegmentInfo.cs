using System;

namespace JolpiApi.Client
{
    /// <summary>
    /// Represents a segment of a URL with an order, name, value, and terminator flag.
    /// </summary>
    public class UrlSegmentInfo : IComparable<UrlSegmentInfo>
    {
        /// <summary>
        /// Gets or sets the order of the URL segment.
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets the name of the URL segment.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the URL segment.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this segment is a terminator.
        /// </summary>
        public bool IsTerminator { get; set; }

        /// <summary>
        /// Compares the current instance with another UrlSegmentInfo object.
        /// </summary>
        /// <param name="other">The UrlSegmentInfo to compare with this instance.</param>
        /// <returns>An integer that indicates the relative order of the objects being compared.</returns>
        public int CompareTo(UrlSegmentInfo other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (other is null) return 1;

            var comparisons = new Func<UrlSegmentInfo, int>[]
            {
                    CompareTerminator,
                    CompareOrder,
                    CompareName
            };

            foreach (var compareTo in comparisons)
            {
                var value = compareTo(other);
                if (value != 0)
                    return value;
            }

            return 0;
        }

        private int CompareTerminator(UrlSegmentInfo other)
        {
            if (IsTerminator) return 1;
            if (other.IsTerminator) return -1;
            return 0;
        }

        private int CompareOrder(UrlSegmentInfo other)
        {
            if (Order == null && other.Order == null) return 0;
            if (Order == null) return 1;
            if (other.Order == null) return -1;

            return Order.Value.CompareTo(other.Order.Value);
        }

        private int CompareName(UrlSegmentInfo other)
        {
            return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}