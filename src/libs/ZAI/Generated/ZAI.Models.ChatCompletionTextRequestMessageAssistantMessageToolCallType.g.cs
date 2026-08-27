
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Tool type, supports web_search, retrieval, function
    /// </summary>
    public enum ChatCompletionTextRequestMessageAssistantMessageToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        Retrieval,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionTextRequestMessageAssistantMessageToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionTextRequestMessageAssistantMessageToolCallType value)
        {
            return value switch
            {
                ChatCompletionTextRequestMessageAssistantMessageToolCallType.Function => "function",
                ChatCompletionTextRequestMessageAssistantMessageToolCallType.Retrieval => "retrieval",
                ChatCompletionTextRequestMessageAssistantMessageToolCallType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionTextRequestMessageAssistantMessageToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionTextRequestMessageAssistantMessageToolCallType.Function,
                "retrieval" => ChatCompletionTextRequestMessageAssistantMessageToolCallType.Retrieval,
                "web_search" => ChatCompletionTextRequestMessageAssistantMessageToolCallType.WebSearch,
                _ => null,
            };
        }
    }
}