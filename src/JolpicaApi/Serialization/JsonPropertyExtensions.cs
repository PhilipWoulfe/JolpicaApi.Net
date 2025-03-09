using System.Linq;
using Newtonsoft.Json.Serialization;

namespace JolpicaApi.Serialization
{
    /// <summary>
    /// Provides extension methods for the <see cref="JsonProperty"/> class.
    /// </summary>
    public static class JsonPropertyExtensions
    {
        /// <summary>
        /// Determines whether the specified <see cref="JsonProperty"/> has an attribute of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the attribute to check for.</typeparam>
        /// <param name="property">The <see cref="JsonProperty"/> to check.</param>
        /// <returns><c>true</c> if the <see cref="JsonProperty"/> has an attribute of the specified type; otherwise, <c>false</c>.</returns>
        public static bool HasAttribute<T>(this JsonProperty property)
        {
            return property.AttributeProvider.GetAttributes(typeof(T), true).Any();
        }

        /// <summary>
        /// Gets the attribute of the specified type from the specified <see cref="JsonProperty"/>.
        /// </summary>
        /// <typeparam name="T">The type of the attribute to get.</typeparam>
        /// <param name="property">The <see cref="JsonProperty"/> to get the attribute from.</param>
        /// <returns>The attribute of the specified type, or <c>null</c> if the attribute is not found.</returns>
        public static T GetAttribute<T>(this JsonProperty property) where T : class
        {
            return property.AttributeProvider.GetAttributes(typeof(T), true).FirstOrDefault() as T;
        }
    }
}
