
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: user
    /// </summary>
    public enum TokenizerRequestMessageUserMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenizerRequestMessageUserMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenizerRequestMessageUserMessageRole value)
        {
            return value switch
            {
                TokenizerRequestMessageUserMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenizerRequestMessageUserMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => TokenizerRequestMessageUserMessageRole.User,
                _ => null,
            };
        }
    }
}