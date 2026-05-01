
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Translation strategy (default: `general`)，Optional:<br/>
    /// - `general`: General Translation<br/>
    /// - `paraphrase`: Paraphrase Translation<br/>
    /// - `two_step`: Two-Step Translation<br/>
    /// - `three_step`: Three-Stage Translation<br/>
    /// - `reflection`: Reflection Translation; cot: COT Translation
    /// </summary>
    public enum TranslationAgentRequestCustomVariablesStrategy
    {
        /// <summary>
        /// `general`)，Optional:
        /// </summary>
        General,
        /// <summary>
        /// Paraphrase Translation
        /// </summary>
        Paraphrase,
        /// <summary>
        /// Reflection Translation; cot: COT Translation
        /// </summary>
        Reflection,
        /// <summary>
        /// Three-Stage Translation
        /// </summary>
        ThreeStep,
        /// <summary>
        /// Two-Step Translation
        /// </summary>
        TwoStep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationAgentRequestCustomVariablesStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationAgentRequestCustomVariablesStrategy value)
        {
            return value switch
            {
                TranslationAgentRequestCustomVariablesStrategy.General => "general",
                TranslationAgentRequestCustomVariablesStrategy.Paraphrase => "paraphrase",
                TranslationAgentRequestCustomVariablesStrategy.Reflection => "reflection",
                TranslationAgentRequestCustomVariablesStrategy.ThreeStep => "three_step",
                TranslationAgentRequestCustomVariablesStrategy.TwoStep => "two_step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationAgentRequestCustomVariablesStrategy? ToEnum(string value)
        {
            return value switch
            {
                "general" => TranslationAgentRequestCustomVariablesStrategy.General,
                "paraphrase" => TranslationAgentRequestCustomVariablesStrategy.Paraphrase,
                "reflection" => TranslationAgentRequestCustomVariablesStrategy.Reflection,
                "three_step" => TranslationAgentRequestCustomVariablesStrategy.ThreeStep,
                "two_step" => TranslationAgentRequestCustomVariablesStrategy.TwoStep,
                _ => null,
            };
        }
    }
}