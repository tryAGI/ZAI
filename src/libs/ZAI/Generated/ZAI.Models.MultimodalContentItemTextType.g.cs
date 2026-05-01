
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is text<br/>
    /// Default Value: text
    /// </summary>
    public enum MultimodalContentItemTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultimodalContentItemTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultimodalContentItemTextType value)
        {
            return value switch
            {
                MultimodalContentItemTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultimodalContentItemTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => MultimodalContentItemTextType.Text,
                _ => null,
            };
        }
    }
}