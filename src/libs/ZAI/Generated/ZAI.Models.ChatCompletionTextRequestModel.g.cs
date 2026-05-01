
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called. GLM-5.1, GLM-5, GLM-5-Turbo are the latest flagship model series, foundational models specifically designed for agent applications.<br/>
    /// Default Value: glm-5.1<br/>
    /// Example: glm-5.1
    /// </summary>
    public enum ChatCompletionTextRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Glm432b0414128k,
        /// <summary>
        /// 
        /// </summary>
        Glm45,
        /// <summary>
        /// 
        /// </summary>
        Glm45Air,
        /// <summary>
        /// 
        /// </summary>
        Glm45Airx,
        /// <summary>
        /// 
        /// </summary>
        Glm45Flash,
        /// <summary>
        /// 
        /// </summary>
        Glm45X,
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
        Glm47Flash,
        /// <summary>
        /// 
        /// </summary>
        Glm47Flashx,
        /// <summary>
        /// 
        /// </summary>
        Glm5,
        /// <summary>
        /// 
        /// </summary>
        Glm5Turbo,
        /// <summary>
        /// 
        /// </summary>
        Glm51,
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
                ChatCompletionTextRequestModel.Glm432b0414128k => "glm-4-32b-0414-128k",
                ChatCompletionTextRequestModel.Glm45 => "glm-4.5",
                ChatCompletionTextRequestModel.Glm45Air => "glm-4.5-air",
                ChatCompletionTextRequestModel.Glm45Airx => "glm-4.5-airx",
                ChatCompletionTextRequestModel.Glm45Flash => "glm-4.5-flash",
                ChatCompletionTextRequestModel.Glm45X => "glm-4.5-x",
                ChatCompletionTextRequestModel.Glm46 => "glm-4.6",
                ChatCompletionTextRequestModel.Glm47 => "glm-4.7",
                ChatCompletionTextRequestModel.Glm47Flash => "glm-4.7-flash",
                ChatCompletionTextRequestModel.Glm47Flashx => "glm-4.7-flashx",
                ChatCompletionTextRequestModel.Glm5 => "glm-5",
                ChatCompletionTextRequestModel.Glm5Turbo => "glm-5-turbo",
                ChatCompletionTextRequestModel.Glm51 => "glm-5.1",
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
                "glm-4-32b-0414-128k" => ChatCompletionTextRequestModel.Glm432b0414128k,
                "glm-4.5" => ChatCompletionTextRequestModel.Glm45,
                "glm-4.5-air" => ChatCompletionTextRequestModel.Glm45Air,
                "glm-4.5-airx" => ChatCompletionTextRequestModel.Glm45Airx,
                "glm-4.5-flash" => ChatCompletionTextRequestModel.Glm45Flash,
                "glm-4.5-x" => ChatCompletionTextRequestModel.Glm45X,
                "glm-4.6" => ChatCompletionTextRequestModel.Glm46,
                "glm-4.7" => ChatCompletionTextRequestModel.Glm47,
                "glm-4.7-flash" => ChatCompletionTextRequestModel.Glm47Flash,
                "glm-4.7-flashx" => ChatCompletionTextRequestModel.Glm47Flashx,
                "glm-5" => ChatCompletionTextRequestModel.Glm5,
                "glm-5-turbo" => ChatCompletionTextRequestModel.Glm5Turbo,
                "glm-5.1" => ChatCompletionTextRequestModel.Glm51,
                _ => null,
            };
        }
    }
}