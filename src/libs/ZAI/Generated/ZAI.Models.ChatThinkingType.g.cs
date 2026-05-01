
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Whether to enable the chain of thought(When enabled, GLM-5.1 GLM-5 GLM-5-Turbo GLM-5V-Turbo GLM-4.7 GLM-4.5V will think compulsorily, while GLM-4.6, GLM-4.6V, GLM-4.5 and others will automatically determine whether to think), default: enabled<br/>
    /// Default Value: enabled
    /// </summary>
    public enum ChatThinkingType
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// enabled
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatThinkingType value)
        {
            return value switch
            {
                ChatThinkingType.Disabled => "disabled",
                ChatThinkingType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ChatThinkingType.Disabled,
                "enabled" => ChatThinkingType.Enabled,
                _ => null,
            };
        }
    }
}