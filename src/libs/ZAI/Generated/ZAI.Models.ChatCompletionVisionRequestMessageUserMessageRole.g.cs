
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: user
    /// </summary>
    public enum ChatCompletionVisionRequestMessageUserMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionVisionRequestMessageUserMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionVisionRequestMessageUserMessageRole value)
        {
            return value switch
            {
                ChatCompletionVisionRequestMessageUserMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionVisionRequestMessageUserMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatCompletionVisionRequestMessageUserMessageRole.User,
                _ => null,
            };
        }
    }
}