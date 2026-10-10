
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called. GLM-5.3, GLM-5.2, GLM-5.1 are the latest flagship model series, foundational models specifically designed for agent applications.<br/>
    /// Default Value: glm-5.3<br/>
    /// Example: glm-5.3
    /// </summary>
    public enum ChatCompletionTextRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        Glm46,
        /// <summary>
        ///
        /// </summary>
        Glm47,
        /// <summary>
        ///
        /// </summary>
        Glm5,
        /// <summary>
        ///
        /// </summary>
        Glm51,
        /// <summary>
        ///
        /// </summary>
        Glm52,
        /// <summary>
        ///
        /// </summary>
        Glm53,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionTextRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionTextRequestModel value)
        {
            return value switch
            {
                ChatCompletionTextRequestModel.Glm46 => "glm-4.6",
                ChatCompletionTextRequestModel.Glm47 => "glm-4.7",
                ChatCompletionTextRequestModel.Glm5 => "glm-5",
                ChatCompletionTextRequestModel.Glm51 => "glm-5.1",
                ChatCompletionTextRequestModel.Glm52 => "glm-5.2",
                ChatCompletionTextRequestModel.Glm53 => "glm-5.3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionTextRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "glm-4.6" => ChatCompletionTextRequestModel.Glm46,
                "glm-4.7" => ChatCompletionTextRequestModel.Glm47,
                "glm-5" => ChatCompletionTextRequestModel.Glm5,
                "glm-5.1" => ChatCompletionTextRequestModel.Glm51,
                "glm-5.2" => ChatCompletionTextRequestModel.Glm52,
                "glm-5.3" => ChatCompletionTextRequestModel.Glm53,
                _ => null,
            };
        }
    }
}