
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Strategy parameters.
    /// </summary>
    public sealed partial class TranslationAgentRequestCustomVariablesStrategyConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("general")]
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigGeneral? General { get; set; }

        /// <summary>
        /// Parameters when strategy is `cot`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cot")]
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCot? Cot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestCustomVariablesStrategyConfig" /> class.
        /// </summary>
        /// <param name="general"></param>
        /// <param name="cot">
        /// Parameters when strategy is `cot`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentRequestCustomVariablesStrategyConfig(
            global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigGeneral? general,
            global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCot? cot)
        {
            this.General = general;
            this.Cot = cot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestCustomVariablesStrategyConfig" /> class.
        /// </summary>
        public TranslationAgentRequestCustomVariablesStrategyConfig()
        {
        }
    }
}