using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using JolpicaApi.Client.Attributes;
using JolpicaApi.Extensions;
using JolpicaApi.Requests;

namespace JolpicaApi.Client
{
    /// <summary>
    /// Builds URLs for Jolpica API requests.
    /// </summary>
    public class UrlBuilder : IUrlBuilder
    {
        /// <summary>
        /// Builds the URL for the given request.
        /// </summary>
        /// <param name="request">The request to build the URL for.</param>
        /// <returns>The built URL as a string.</returns>
        public string Build(IJolpiRequest request)
        {
            var segments = GetSegments(request);

            var url = "";
            foreach (var segment in segments)
            {
                if (segment.Name != null)
                    url += $"/{segment.Name}";

                if (segment.Value != null)
                    url += $"/{segment.Value}";
            }

            url += ".json";

            if (request.Limit != null)
                url += "?limit=" + request.Limit;

            if (request.Offset != null)
            {
                url += request.Limit == null ? "?" : "&";
                url += "offset=" + request.Offset;
            }

            return url;
        }

        /// <summary>
        /// Gets the segments for the given request.
        /// </summary>
        /// <param name="request">The request to get the segments for.</param>
        /// <returns>A list of URL segment information.</returns>
        private static List<UrlSegmentInfo> GetSegments(IJolpiRequest request)
        {
            var segments = new List<UrlSegmentInfo>();
            var properties = request.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var prop in properties)
            {
                var urlSegment = prop.GetCustomAttribute<UrlSegmentAttribute>(true);
                var urlTerminator = prop.GetCustomAttribute<UrlTerminatorAttribute>(true);

                if (urlSegment == null)
                    continue;

                var segment = new UrlSegmentInfo
                {
                    Order = urlSegment.NullableOrder,
                    Name = urlSegment.SegmentName,
                    Value = GetSegmentValue(prop, request),
                    IsTerminator = urlTerminator != null
                };

                if (segment.Value == null && !segment.IsTerminator)
                    continue;

                segments.Add(segment);
            }

            if (segments.Count(x => x.IsTerminator) > 1)
                throw new Exception("A request can only have one property with the UrlTerminator attribute");

            segments.Sort();

            return segments;
        }

        /// <summary>
        /// Gets the value of the segment for the given property and request.
        /// </summary>
        /// <param name="property">The property to get the segment value for.</param>
        /// <param name="request">The request to get the segment value for.</param>
        /// <returns>The segment value as a string.</returns>
        private static string GetSegmentValue(PropertyInfo property, IJolpiRequest request)
        {
            var value = property.GetValue(request);
            if (value?.GetType().IsEnum() == true)
                value = (int)value;

            return value?.ToString();
        }
    }
}
