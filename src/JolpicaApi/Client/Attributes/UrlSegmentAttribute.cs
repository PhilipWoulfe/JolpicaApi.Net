using System;

namespace JolpicaApi.Client.Attributes
{
    /// <summary>
    /// Attribute to define URL segments for properties.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class UrlSegmentAttribute : Attribute
    {
        /// <summary>
        /// "Hack" as nullables can't be used with attributes
        /// </summary>
        internal int? NullableOrder { get; set; }

        /// <summary>
        /// Gets or sets the order of the URL segment.
        /// </summary>
        public int Order
        {
            get => NullableOrder ?? default;
            set => NullableOrder = value;
        }

        /// <summary>
        /// Gets or sets the name of the URL segment.
        /// </summary>
        public string SegmentName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlSegmentAttribute"/> class.
        /// </summary>
        public UrlSegmentAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlSegmentAttribute"/> class with a specified segment name.
        /// </summary>
        /// <param name="segmentName">The name of the URL segment.</param>
        public UrlSegmentAttribute(string segmentName)
        {
            SegmentName = segmentName;
        }
    }
}