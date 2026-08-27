
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Specifies that this content is text.
    /// </summary>
    public enum GlmSlideAgentRequestMessageContentItemType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlmSlideAgentRequestMessageContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlmSlideAgentRequestMessageContentItemType value)
        {
            return value switch
            {
                GlmSlideAgentRequestMessageContentItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlmSlideAgentRequestMessageContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "text" => GlmSlideAgentRequestMessageContentItemType.Text,
                _ => null,
            };
        }
    }
}