
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called.<br/>
    /// Default Value: glm-4.6<br/>
    /// Example: glm-4.6
    /// </summary>
    public enum TokenizerRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Glm45,
        /// <summary>
        /// 
        /// </summary>
        Glm46,
        /// <summary>
        /// 
        /// </summary>
        Glm46v,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenizerRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenizerRequestModel value)
        {
            return value switch
            {
                TokenizerRequestModel.Glm45 => "glm-4.5",
                TokenizerRequestModel.Glm46 => "glm-4.6",
                TokenizerRequestModel.Glm46v => "glm-4.6v",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenizerRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "glm-4.5" => TokenizerRequestModel.Glm45,
                "glm-4.6" => TokenizerRequestModel.Glm46,
                "glm-4.6v" => TokenizerRequestModel.Glm46v,
                _ => null,
            };
        }
    }
}