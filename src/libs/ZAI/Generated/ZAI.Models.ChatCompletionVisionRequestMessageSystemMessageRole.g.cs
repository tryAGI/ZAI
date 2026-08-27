
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: system
    /// </summary>
    public enum ChatCompletionVisionRequestMessageSystemMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionVisionRequestMessageSystemMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionVisionRequestMessageSystemMessageRole value)
        {
            return value switch
            {
                ChatCompletionVisionRequestMessageSystemMessageRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionVisionRequestMessageSystemMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionVisionRequestMessageSystemMessageRole.System,
                _ => null,
            };
        }
    }
}