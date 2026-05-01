
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Model code: `glm-ocr`<br/>
    /// Example: glm-ocr
    /// </summary>
    public enum LayoutParsingRequestModel
    {
        /// <summary>
        /// `glm-ocr`
        /// </summary>
        GlmOcr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayoutParsingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayoutParsingRequestModel value)
        {
            return value switch
            {
                LayoutParsingRequestModel.GlmOcr => "glm-ocr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayoutParsingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "glm-ocr" => LayoutParsingRequestModel.GlmOcr,
                _ => null,
            };
        }
    }
}