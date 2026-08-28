
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is file. New unified file type, compatible with the legacy `file_url` type but not recommended for new scenarios. Not support passing both the `file` and `image_url` or `video_url` parameters at the same time.<br/>
    /// Default Value: file
    /// </summary>
    public enum VisionMultimodalContentItemFileType
    {
        /// <summary>
        ///
        /// </summary>
        File,
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
                VisionMultimodalContentItemFileType.File => "file",
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
                "file" => VisionMultimodalContentItemFileType.File,
                _ => null,
            };
        }
    }
}