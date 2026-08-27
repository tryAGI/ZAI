
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is file URL, not support passing both the `file_url` and `image_url` or `video_url` parameters at the same time.<br/>
    /// Default Value: file_url
    /// </summary>
    public enum VisionMultimodalContentItemFileType
    {
        /// <summary>
        ///
        /// </summary>
        FileUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisionMultimodalContentItemFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisionMultimodalContentItemFileType value)
        {
            return value switch
            {
                VisionMultimodalContentItemFileType.FileUrl => "file_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisionMultimodalContentItemFileType? ToEnum(string value)
        {
            return value switch
            {
                "file_url" => VisionMultimodalContentItemFileType.FileUrl,
                _ => null,
            };
        }
    }
}