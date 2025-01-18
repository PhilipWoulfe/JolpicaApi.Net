using System;
using System.Linq;
using System.Reflection;
using JolpiApi.Serialization.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JolpiApi.Serialization
{
    /// <summary>
    /// A custom contract resolver that supports JSON path properties.
    /// </summary>
    public class JsonPathContractResolver : DefaultContractResolver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonPathContractResolver"/> class.
        /// </summary>
        public JsonPathContractResolver()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonPathContractResolver"/> class with a specified naming strategy.
        /// </summary>
        /// <param name="namingStrategy">The naming strategy to use.</param>
        public JsonPathContractResolver(NamingStrategy namingStrategy)
        {
            NamingStrategy = namingStrategy;
        }

        private static bool HasPropertiesUsingJsonPath(JsonObjectContract contract)
        {
            return contract.Properties.Any(x => x.AttributeProvider
                .GetAttributes(typeof(JsonPathPropertyAttribute), true)
                .Any());
        }

        /// <inheritdoc />
        protected override JsonObjectContract CreateObjectContract(Type objectType)
        {
            var contract = base.CreateObjectContract(objectType);

            var jsonPathProperties = contract.Properties
                    .Where(x => x.HasAttribute<JsonPathPropertyAttribute>())
                    .Select(x => new JsonPathPropertyInfo
                    {
                        JsonProperty = x,
                        Path = x.GetAttribute<JsonPathPropertyAttribute>().Path
                    });

            if (HasPropertiesUsingJsonPath(contract))
                contract.Converter = new JsonPathConverter(jsonPathProperties);

            return contract;
        }

        /// <inheritdoc />
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var prop = base.CreateProperty(member, memberSerialization);

            prop.Writable = prop.Writable ? prop.Writable : HasPrivateSetter(member);

            if (!prop.Ignored)
            {
                prop.Ignored = prop.HasAttribute<JsonPathPropertyAttribute>();
            }

            return prop;
        }

        private static bool HasPrivateSetter(MemberInfo member)
        {
            var property = member as PropertyInfo;
            return property?.GetSetMethod(true) != null;
        }
    }
}
