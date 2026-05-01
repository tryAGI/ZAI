
#nullable enable

namespace ZAI
{
    /// <summary>
    /// User input role: `user`<br/>
    /// Default Value: user<br/>
    /// Example: user
    /// </summary>
    public enum TranslationAgentRequestMessageRole
    {
        /// <summary>
        /// `user`
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationAgentRequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationAgentRequestMessageRole value)
        {
            return value switch
            {
                TranslationAgentRequestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationAgentRequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => TranslationAgentRequestMessageRole.User,
                _ => null,
            };
        }
    }
}