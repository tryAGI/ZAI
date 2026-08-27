
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Default Value: web_search
    /// </summary>
    public enum WebSearchToolSchemaType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolSchemaType value)
        {
            return value switch
            {
                WebSearchToolSchemaType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => WebSearchToolSchemaType.WebSearch,
                _ => null,
            };
        }
    }
}