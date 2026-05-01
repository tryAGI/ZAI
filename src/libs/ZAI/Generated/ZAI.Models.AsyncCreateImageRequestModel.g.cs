
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Model code<br/>
    /// Example: glm-image
    /// </summary>
    public enum AsyncCreateImageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        GlmImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncCreateImageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncCreateImageRequestModel value)
        {
            return value switch
            {
                AsyncCreateImageRequestModel.GlmImage => "glm-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncCreateImageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "glm-image" => AsyncCreateImageRequestModel.GlmImage,
                _ => null,
            };
        }
    }
}