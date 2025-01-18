using System.Collections.Generic;
using JolpicaApi.Responses.Models;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses
{
    public class ConstructorResponse : JolpiResponse
    {
        [JsonPathProperty("ConstructorTable.Constructors")]
        public IList<Constructor> Constructors { get; private set; }
    }
}
