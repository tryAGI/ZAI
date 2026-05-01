
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Type of search engine.<br/>
    /// Default is `search_pro_jina`. Supports: `search_pro_jina`.
    /// </summary>
    public enum WebSearchObjectSearchEngine
    {
        /// <summary>
        /// `search_pro_jina`.
        /// </summary>
        SearchProJina,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchObjectSearchEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchObjectSearchEngine value)
        {
            return value switch
            {
                WebSearchObjectSearchEngine.SearchProJina => "search_pro_jina",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchObjectSearchEngine? ToEnum(string value)
        {
            return value switch
            {
                "search_pro_jina" => WebSearchObjectSearchEngine.SearchProJina,
                _ => null,
            };
        }
    }
}