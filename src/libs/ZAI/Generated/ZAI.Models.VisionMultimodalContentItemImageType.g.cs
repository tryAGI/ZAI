
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is image URL<br/>
    /// Default Value: image_url
    /// </summary>
    public enum VisionMultimodalContentItemImageType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisionMultimodalContentItemImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisionMultimodalContentItemImageType value)
        {
            return value switch
            {
                VisionMultimodalContentItemImageType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisionMultimodalContentItemImageType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => VisionMultimodalContentItemImageType.ImageUrl,
                _ => null,
            };
        }
    }
}