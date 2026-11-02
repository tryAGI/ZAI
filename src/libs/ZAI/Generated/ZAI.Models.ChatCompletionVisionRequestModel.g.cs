
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called. The `GLM-5.3-Flash` series supports visual understanding, delivering excellent multimodal comprehension and tool calling capabilities. The `glm-5.3-flashx-legal` variant is further optimized for professional legal workflows such as legal research, contract review, and legal document drafting.<br/>
    /// Default Value: glm-5.3-flashx<br/>
    /// Example: glm-5.3-flashx
    /// </summary>
    public enum ChatCompletionVisionRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        Glm53Flash,
        /// <summary>
        ///
        /// </summary>
        Glm53Flashx,
        /// <summary>
        ///
        /// </summary>
        Glm53FlashxLegal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionVisionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionVisionRequestModel value)
        {
            return value switch
            {
                ChatCompletionVisionRequestModel.Glm53Flash => "glm-5.3-flash",
                ChatCompletionVisionRequestModel.Glm53Flashx => "glm-5.3-flashx",
                ChatCompletionVisionRequestModel.Glm53FlashxLegal => "glm-5.3-flashx-legal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionVisionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "glm-5.3-flash" => ChatCompletionVisionRequestModel.Glm53Flash,
                "glm-5.3-flashx" => ChatCompletionVisionRequestModel.Glm53Flashx,
                "glm-5.3-flashx-legal" => ChatCompletionVisionRequestModel.Glm53FlashxLegal,
                _ => null,
            };
        }
    }
}