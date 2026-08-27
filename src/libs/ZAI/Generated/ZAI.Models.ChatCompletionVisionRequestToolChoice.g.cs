
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Used to control how the model selects which function to call. This is only applicable when the tool type is function. The default value is auto, and only auto is supported.
    /// </summary>
    public enum ChatCompletionVisionRequestToolChoice
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionVisionRequestToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionVisionRequestToolChoice value)
        {
            return value switch
            {
                ChatCompletionVisionRequestToolChoice.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionVisionRequestToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionVisionRequestToolChoice.Auto,
                _ => null,
            };
        }
    }
}