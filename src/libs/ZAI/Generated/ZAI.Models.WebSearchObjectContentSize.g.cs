
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Number of characters for webpage summaries.<br/>
    /// Default is `medium`<br/>
    /// `medium`: Balanced mode for most queries. 400-600 characters<br/>
    /// `high`: Maximizes context for comprehensive answers, 2500 characters.
    /// </summary>
    public enum WebSearchObjectContentSize
    {
        /// <summary>
        /// Maximizes context for comprehensive answers, 2500 characters.
        /// </summary>
        High,
        /// <summary>
        /// Balanced mode for most queries. 400-600 characters
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchObjectContentSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchObjectContentSize value)
        {
            return value switch
            {
                WebSearchObjectContentSize.High => "high",
                WebSearchObjectContentSize.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchObjectContentSize? ToEnum(string value)
        {
            return value switch
            {
                "high" => WebSearchObjectContentSize.High,
                "medium" => WebSearchObjectContentSize.Medium,
                _ => null,
            };
        }
    }
}