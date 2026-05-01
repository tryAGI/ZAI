
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is video URL<br/>
    /// Default Value: video_url
    /// </summary>
    public enum MultimodalContentItemVideoType
    {
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultimodalContentItemVideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultimodalContentItemVideoType value)
        {
            return value switch
            {
                MultimodalContentItemVideoType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultimodalContentItemVideoType? ToEnum(string value)
        {
            return value switch
            {
                "video_url" => MultimodalContentItemVideoType.VideoUrl,
                _ => null,
            };
        }
    }
}