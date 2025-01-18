using System.Collections.Generic;
using JolpiApi.Responses.Models;
using JolpiApi.Serialization;

namespace JolpiApi.Responses
{
    public class ConstructorResponse : ErgastResponse
    {
        [JsonPathProperty("ConstructorTable.Constructors")]
        public IList<Constructor> Constructors { get; private set; }
    }
}
