
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: assistant
    /// </summary>
    public enum ChatCompletionVisionRequestMessageAssistantMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionVisionRequestMessageAssistantMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionVisionRequestMessageAssistantMessageRole value)
        {
            return value switch
            {
                ChatCompletionVisionRequestMessageAssistantMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionVisionRequestMessageAssistantMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionVisionRequestMessageAssistantMessageRole.Assistant,
                _ => null,
            };
        }
    }
}