using System.Collections.Generic;
using JolpicaApi.Responses.Models;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses
{
    /// <summary>
    /// Represents a response containing a list of constructors.
    /// </summary>
    public class ConstructorResponse : JolpicaResponse
    {
        /// <summary>
        /// Gets the list of constructors.
        /// </summary>
        /// <value>
        /// A list of <see cref="Constructor"/> objects.
        /// </value>
        [JsonPathProperty("ConstructorTable.Constructors")]
        public IList<Constructor> Constructors { get; private set; }
    }
}
