
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Specifies that this content is text.
    /// </summary>
    public enum SpecialEffectsVideosAgentRequestMessageContentItemTextType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpecialEffectsVideosAgentRequestMessageContentItemTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpecialEffectsVideosAgentRequestMessageContentItemTextType value)
        {
            return value switch
            {
                SpecialEffectsVideosAgentRequestMessageContentItemTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpecialEffectsVideosAgentRequestMessageContentItemTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => SpecialEffectsVideosAgentRequestMessageContentItemTextType.Text,
                _ => null,
            };
        }
    }
}