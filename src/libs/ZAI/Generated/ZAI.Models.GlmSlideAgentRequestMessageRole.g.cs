
#nullable enable

namespace ZAI
{
    /// <summary>
    /// User input role: `user`<br/>
    /// Default Value: user<br/>
    /// Example: user
    /// </summary>
    public enum GlmSlideAgentRequestMessageRole
    {
        /// <summary>
        /// `user`
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlmSlideAgentRequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlmSlideAgentRequestMessageRole value)
        {
            return value switch
            {
                GlmSlideAgentRequestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlmSlideAgentRequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => GlmSlideAgentRequestMessageRole.User,
                _ => null,
            };
        }
    }
}