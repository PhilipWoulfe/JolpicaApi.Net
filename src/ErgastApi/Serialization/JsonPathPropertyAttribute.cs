using System;

namespace JolpiApi.Serialization
{
    public class JsonPathPropertyAttribute : Attribute
    {
        public string Path { get; set; }

        public JsonPathPropertyAttribute(string path)
        {
            Path = path;
        }
    }
}
