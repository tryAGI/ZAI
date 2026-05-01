
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Model code<br/>
    /// Example: glm-image
    /// </summary>
    public enum CreateImageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Cogview4250304,
        /// <summary>
        /// 
        /// </summary>
        GlmImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestModel value)
        {
            return value switch
            {
                CreateImageRequestModel.Cogview4250304 => "cogview-4-250304",
                CreateImageRequestModel.GlmImage => "glm-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "cogview-4-250304" => CreateImageRequestModel.Cogview4250304,
                "glm-image" => CreateImageRequestModel.GlmImage,
                _ => null,
            };
        }
    }
}