
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called. The `GLM-5.3-Flash` series supports visual understanding, delivering excellent multimodal comprehension and tool calling capabilities.<br/>
    /// Default Value: glm-5.3-flash<br/>
    /// Example: glm-5.3-flash
    /// </summary>
    public enum ChatCompletionVisionRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        AutoglmPhoneMultilingual,
        /// <summary>
        ///
        /// </summary>
        Glm45v,
        /// <summary>
        ///
        /// </summary>
        Glm46v,
        /// <summary>
        ///
        /// </summary>
        Glm46vFlash,
        /// <summary>
        ///
        /// </summary>
        Glm46vFlashx,
        /// <summary>
        ///
        /// </summary>
        Glm53Flash,
        /// <summary>
        ///
        /// </summary>
        Glm5vTurbo,
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
                ChatCompletionVisionRequestModel.AutoglmPhoneMultilingual => "autoglm-phone-multilingual",
                ChatCompletionVisionRequestModel.Glm45v => "glm-4.5v",
                ChatCompletionVisionRequestModel.Glm46v => "glm-4.6v",
                ChatCompletionVisionRequestModel.Glm46vFlash => "glm-4.6v-flash",
                ChatCompletionVisionRequestModel.Glm46vFlashx => "glm-4.6v-flashx",
                ChatCompletionVisionRequestModel.Glm53Flash => "glm-5.3-flash",
                ChatCompletionVisionRequestModel.Glm5vTurbo => "glm-5v-turbo",
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
                "autoglm-phone-multilingual" => ChatCompletionVisionRequestModel.AutoglmPhoneMultilingual,
                "glm-4.5v" => ChatCompletionVisionRequestModel.Glm45v,
                "glm-4.6v" => ChatCompletionVisionRequestModel.Glm46v,
                "glm-4.6v-flash" => ChatCompletionVisionRequestModel.Glm46vFlash,
                "glm-4.6v-flashx" => ChatCompletionVisionRequestModel.Glm46vFlashx,
                "glm-5.3-flash" => ChatCompletionVisionRequestModel.Glm53Flash,
                "glm-5v-turbo" => ChatCompletionVisionRequestModel.Glm5vTurbo,
                _ => null,
            };
        }
    }
}