
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: tool
    /// </summary>
    public enum ChatCompletionTextRequestMessageToolMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionTextRequestMessageToolMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionTextRequestMessageToolMessageRole value)
        {
            return value switch
            {
                ChatCompletionTextRequestMessageToolMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionTextRequestMessageToolMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatCompletionTextRequestMessageToolMessageRole.Tool,
                _ => null,
            };
        }
    }
}