
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is image URL<br/>
    /// Default Value: image_url
    /// </summary>
    public enum MultimodalContentItemImageType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultimodalContentItemImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultimodalContentItemImageType value)
        {
            return value switch
            {
                MultimodalContentItemImageType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultimodalContentItemImageType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MultimodalContentItemImageType.ImageUrl,
                _ => null,
            };
        }
    }
}