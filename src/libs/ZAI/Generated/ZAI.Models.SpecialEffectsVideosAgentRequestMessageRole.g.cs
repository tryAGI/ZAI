
#nullable enable

namespace ZAI
{
    /// <summary>
    /// User input role: `user`<br/>
    /// Default Value: user<br/>
    /// Example: user
    /// </summary>
    public enum SpecialEffectsVideosAgentRequestMessageRole
    {
        /// <summary>
        /// `user`
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpecialEffectsVideosAgentRequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpecialEffectsVideosAgentRequestMessageRole value)
        {
            return value switch
            {
                SpecialEffectsVideosAgentRequestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpecialEffectsVideosAgentRequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => SpecialEffectsVideosAgentRequestMessageRole.User,
                _ => null,
            };
        }
    }
}