
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: assistant
    /// </summary>
    public enum ChatCompletionTextRequestMessageAssistantMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionTextRequestMessageAssistantMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionTextRequestMessageAssistantMessageRole value)
        {
            return value switch
            {
                ChatCompletionTextRequestMessageAssistantMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionTextRequestMessageAssistantMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionTextRequestMessageAssistantMessageRole.Assistant,
                _ => null,
            };
        }
    }
}