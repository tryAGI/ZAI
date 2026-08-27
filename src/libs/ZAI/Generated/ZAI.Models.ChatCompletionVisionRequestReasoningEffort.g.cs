
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Controls the model's reasoning effort level, takes effect when `thinking` is enabled. Default is `max`.<br/>
    /// Default Value: max<br/>
    /// Example: max
    /// </summary>
    public enum ChatCompletionVisionRequestReasoningEffort
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionVisionRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionVisionRequestReasoningEffort value)
        {
            return value switch
            {
                ChatCompletionVisionRequestReasoningEffort.High => "high",
                ChatCompletionVisionRequestReasoningEffort.Low => "low",
                ChatCompletionVisionRequestReasoningEffort.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionVisionRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatCompletionVisionRequestReasoningEffort.High,
                "low" => ChatCompletionVisionRequestReasoningEffort.Low,
                "max" => ChatCompletionVisionRequestReasoningEffort.Max,
                _ => null,
            };
        }
    }
}