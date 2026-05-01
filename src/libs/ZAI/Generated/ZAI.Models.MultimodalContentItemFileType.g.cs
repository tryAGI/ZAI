
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is file URL<br/>
    /// Default Value: file_url
    /// </summary>
    public enum MultimodalContentItemFileType
    {
        /// <summary>
        /// 
        /// </summary>
        FileUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultimodalContentItemFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultimodalContentItemFileType value)
        {
            return value switch
            {
                MultimodalContentItemFileType.FileUrl => "file_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultimodalContentItemFileType? ToEnum(string value)
        {
            return value switch
            {
                "file_url" => MultimodalContentItemFileType.FileUrl,
                _ => null,
            };
        }
    }
}