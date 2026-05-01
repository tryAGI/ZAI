
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Agent ID: `general_translation`.
    /// </summary>
    public enum TranslationAgentRequestAgentId
    {
        /// <summary>
        /// `general_translation`.
        /// </summary>
        GeneralTranslation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationAgentRequestAgentIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationAgentRequestAgentId value)
        {
            return value switch
            {
                TranslationAgentRequestAgentId.GeneralTranslation => "general_translation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationAgentRequestAgentId? ToEnum(string value)
        {
            return value switch
            {
                "general_translation" => TranslationAgentRequestAgentId.GeneralTranslation,
                _ => null,
            };
        }
    }
}