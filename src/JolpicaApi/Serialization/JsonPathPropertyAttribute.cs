using System;

namespace JolpicaApi.Serialization
{
    /// <summary>
    /// Specifies the JSON path for a property.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="JsonPathPropertyAttribute"/> class with the specified JSON path.
    /// </remarks>
    /// <param name="path">The JSON path.</param>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class JsonPathPropertyAttribute(string path) : Attribute
    {
        /// <summary>
        /// Gets or sets the JSON path.
        /// </summary>
        public string Path { get; set; } = path;
    }
}
