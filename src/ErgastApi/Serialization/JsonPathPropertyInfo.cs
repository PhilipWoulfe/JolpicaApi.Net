using Newtonsoft.Json.Serialization;

namespace JolpiApi.Serialization
{
    public class JsonPathPropertyInfo
    {
        public JsonProperty JsonProperty { get; set; }

        public string Path { get; set; }
    }
}
