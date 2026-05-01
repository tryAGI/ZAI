
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Specifies that this content is an image URL.
    /// </summary>
    public enum SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpecialEffectsVideosAgentRequestMessageContentItemImageUrlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType value)
        {
            return value switch
            {
                SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType.ImageUrl,
                _ => null,
            };
        }
    }
}