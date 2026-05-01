
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Language for translation reasoning, values: [`from`｜`to`], default: `to`.
    /// </summary>
    public enum TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang
    {
        /// <summary>
        /// [`from`｜`to`], default: `to`.
        /// </summary>
        From,
        /// <summary>
        /// [`from`｜`to`], default: `to`.
        /// </summary>
        To,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLangExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang value)
        {
            return value switch
            {
                TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang.From => "from",
                TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang.To => "to",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang? ToEnum(string value)
        {
            return value switch
            {
                "from" => TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang.From,
                "to" => TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang.To,
                _ => null,
            };
        }
    }
}