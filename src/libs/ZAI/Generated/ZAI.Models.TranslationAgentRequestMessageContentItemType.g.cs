
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Supported type: `text`.<br/>
    /// Default Value: text
    /// </summary>
    public enum TranslationAgentRequestMessageContentItemType
    {
        /// <summary>
        /// `text`.
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationAgentRequestMessageContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationAgentRequestMessageContentItemType value)
        {
            return value switch
            {
                TranslationAgentRequestMessageContentItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationAgentRequestMessageContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TranslationAgentRequestMessageContentItemType.Text,
                _ => null,
            };
        }
    }
}