
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: assistant
    /// </summary>
    public enum TokenizerRequestMessageAssistantMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenizerRequestMessageAssistantMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenizerRequestMessageAssistantMessageRole value)
        {
            return value switch
            {
                TokenizerRequestMessageAssistantMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenizerRequestMessageAssistantMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => TokenizerRequestMessageAssistantMessageRole.Assistant,
                _ => null,
            };
        }
    }
}