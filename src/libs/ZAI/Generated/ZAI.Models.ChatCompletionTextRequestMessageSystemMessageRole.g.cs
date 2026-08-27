
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: system
    /// </summary>
    public enum ChatCompletionTextRequestMessageSystemMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionTextRequestMessageSystemMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionTextRequestMessageSystemMessageRole value)
        {
            return value switch
            {
                ChatCompletionTextRequestMessageSystemMessageRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionTextRequestMessageSystemMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionTextRequestMessageSystemMessageRole.System,
                _ => null,
            };
        }
    }
}