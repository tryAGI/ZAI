
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Controls the model's reasoning effort level, takes effect when `thinking` is enabled. Default is `max`. Only supported by `GLM-5.2`. For compatibility with other protocols, passing `none` or `minimal` will cause the model to skip thinking; `low` and `medium` will be mapped to `high`; `xhigh` will be mapped to `max`.<br/>
    /// Default Value: max<br/>
    /// Example: max
    /// </summary>
    public enum ChatCompletionTextRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionTextRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionTextRequestReasoningEffort value)
        {
            return value switch
            {
                ChatCompletionTextRequestReasoningEffort.High => "high",
                ChatCompletionTextRequestReasoningEffort.Low => "low",
                ChatCompletionTextRequestReasoningEffort.Max => "max",
                ChatCompletionTextRequestReasoningEffort.Medium => "medium",
                ChatCompletionTextRequestReasoningEffort.Minimal => "minimal",
                ChatCompletionTextRequestReasoningEffort.None => "none",
                ChatCompletionTextRequestReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionTextRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatCompletionTextRequestReasoningEffort.High,
                "low" => ChatCompletionTextRequestReasoningEffort.Low,
                "max" => ChatCompletionTextRequestReasoningEffort.Max,
                "medium" => ChatCompletionTextRequestReasoningEffort.Medium,
                "minimal" => ChatCompletionTextRequestReasoningEffort.Minimal,
                "none" => ChatCompletionTextRequestReasoningEffort.None,
                "xhigh" => ChatCompletionTextRequestReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}