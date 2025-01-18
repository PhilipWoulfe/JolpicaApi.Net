using Newtonsoft.Json.Serialization;

namespace JolpicaApi.Serialization
{
    public class JsonPathPropertyInfo
    {
        public JsonProperty JsonProperty { get; set; }

        public string Path { get; set; }
    }
}
