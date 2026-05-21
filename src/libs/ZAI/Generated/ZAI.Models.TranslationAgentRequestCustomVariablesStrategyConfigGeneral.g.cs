
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationAgentRequestCustomVariablesStrategyConfigGeneral
    {
        /// <summary>
        /// Translation suggestions or style requirements (e.g., terminology mapping, style guidelines).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestion")]
        public string? Suggestion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestCustomVariablesStrategyConfigGeneral" /> class.
        /// </summary>
        /// <param name="suggestion">
        /// Translation suggestions or style requirements (e.g., terminology mapping, style guidelines).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentRequestCustomVariablesStrategyConfigGeneral(
            string? suggestion)
        {
            this.Suggestion = suggestion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestCustomVariablesStrategyConfigGeneral" /> class.
        /// </summary>
        public TranslationAgentRequestCustomVariablesStrategyConfigGeneral()
        {
        }

    }
}