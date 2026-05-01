
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Specifies whether search results are shown before or after model response. Options: `before`, `after`. Default is `after`
    /// </summary>
    public enum WebSearchObjectResultSequence
    {
        /// <summary>
        /// `before`, `after`. Default is `after`
        /// </summary>
        After,
        /// <summary>
        /// `before`, `after`. Default is `after`
        /// </summary>
        Before,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchObjectResultSequenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchObjectResultSequence value)
        {
            return value switch
            {
                WebSearchObjectResultSequence.After => "after",
                WebSearchObjectResultSequence.Before => "before",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchObjectResultSequence? ToEnum(string value)
        {
            return value switch
            {
                "after" => WebSearchObjectResultSequence.After,
                "before" => WebSearchObjectResultSequence.Before,
                _ => null,
            };
        }
    }
}