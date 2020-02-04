using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Avalara.CommsPlatform.Api.Models.Swagger
{
    /// <summary>
    /// Attribute that specifies if a field or property should be ignored when generating swagger document
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class SwaggerIgnoreAttribute : Attribute
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class SwaggerIgnoreFilter : ISchemaFilter
    {
        /// <summary>
        /// Applies the specified filter to swagger.
        /// </summary>
        /// <param name="schema">The schema.</param>
        /// <param name="schemaFilterContext">The schema filter context.</param>
        public void Apply(Schema schema, SchemaFilterContext schemaFilterContext)
        {
            if (schema?.Properties?.Count == 0)
            {
                return;
            }

            const BindingFlags bindingFlags = BindingFlags.Public |
                                              BindingFlags.NonPublic |
                                              BindingFlags.Instance;
            var memberList = schemaFilterContext.SystemType
                .GetFields(bindingFlags).Cast<MemberInfo>()
                .Concat(schemaFilterContext.SystemType
                    .GetProperties(bindingFlags));

            var excludedList = memberList.Where(m =>
                    m.GetCustomAttribute<SwaggerIgnoreAttribute>()
                    != null)
                .Select(m =>
                    (m.GetCustomAttribute<JsonPropertyAttribute>()
                         ?.PropertyName
                     ?? m.Name.ToCamelCase()));

            foreach (var excludedName in excludedList)
            {
                if (schema.Properties.ContainsKey(excludedName))
                {
                    schema.Properties.Remove(excludedName);
                }
            }
        }
    }
    /// <summary>
    /// Helper class
    /// </summary>
    internal static class StringExtensions
    {
        internal static string ToCamelCase(this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return char.ToLowerInvariant(value[0]) + value.Substring(1);
        }
    }
}