
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The search engine code to call.<br/>
    ///  search-prime: Z.AI Premium Version Search Engine<br/>
    /// Default Value: search-prime<br/>
    /// Example: search-prime
    /// </summary>
    public enum WebSearchRequestSearchEngine
    {
        /// <summary>
        /// Z.AI Premium Version Search Engine
        /// </summary>
        SearchPrime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestSearchEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestSearchEngine value)
        {
            return value switch
            {
                WebSearchRequestSearchEngine.SearchPrime => "search-prime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestSearchEngine? ToEnum(string value)
        {
            return value switch
            {
                "search-prime" => WebSearchRequestSearchEngine.SearchPrime,
                _ => null,
            };
        }
    }
}