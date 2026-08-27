
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Role of the message author<br/>
    /// Default Value: system
    /// </summary>
    public enum TokenizerRequestMessageSystemMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenizerRequestMessageSystemMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenizerRequestMessageSystemMessageRole value)
        {
            return value switch
            {
                TokenizerRequestMessageSystemMessageRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenizerRequestMessageSystemMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => TokenizerRequestMessageSystemMessageRole.System,
                _ => null,
            };
        }
    }
}