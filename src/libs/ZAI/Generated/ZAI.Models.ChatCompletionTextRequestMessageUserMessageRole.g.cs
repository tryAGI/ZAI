
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: user
    /// </summary>
    public enum ChatCompletionTextRequestMessageUserMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionTextRequestMessageUserMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionTextRequestMessageUserMessageRole value)
        {
            return value switch
            {
                ChatCompletionTextRequestMessageUserMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionTextRequestMessageUserMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatCompletionTextRequestMessageUserMessageRole.User,
                _ => null,
            };
        }
    }
}