
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is file ID, only GLM-5.3-Flash supported, get the ID via the [File Upload API](/api-reference/agents/file-upload) <br/>
    /// Default Value: file
    /// </summary>
    public enum VisionMultimodalContentItemFileIdType
    {
        /// <summary>
        ///
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisionMultimodalContentItemFileIdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisionMultimodalContentItemFileIdType value)
        {
            return value switch
            {
                VisionMultimodalContentItemFileIdType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisionMultimodalContentItemFileIdType? ToEnum(string value)
        {
            return value switch
            {
                "file" => VisionMultimodalContentItemFileIdType.File,
                _ => null,
            };
        }
    }
}