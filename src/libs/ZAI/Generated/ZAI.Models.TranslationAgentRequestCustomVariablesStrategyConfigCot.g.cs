
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Parameters when strategy is `cot`.
    /// </summary>
    public sealed partial class TranslationAgentRequestCustomVariablesStrategyConfigCot
    {
        /// <summary>
        /// Language for translation reasoning, values: [`from`｜`to`], default: `to`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason_lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLangJsonConverter))]
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang? ReasonLang { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestCustomVariablesStrategyConfigCot" /> class.
        /// </summary>
        /// <param name="reasonLang">
        /// Language for translation reasoning, values: [`from`｜`to`], default: `to`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentRequestCustomVariablesStrategyConfigCot(
            global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang? reasonLang)
        {
            this.ReasonLang = reasonLang;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestCustomVariablesStrategyConfigCot" /> class.
        /// </summary>
        public TranslationAgentRequestCustomVariablesStrategyConfigCot()
        {
        }
    }
}