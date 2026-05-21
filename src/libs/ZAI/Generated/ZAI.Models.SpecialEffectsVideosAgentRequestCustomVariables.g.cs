
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Agent extension parameters.
    /// </summary>
    public sealed partial class SpecialEffectsVideosAgentRequestCustomVariables
    {
        /// <summary>
        /// Effect template: `french_kiss`, `bodyshake`, or `sexy_me`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestCustomVariablesTemplateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.SpecialEffectsVideosAgentRequestCustomVariablesTemplate Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentRequestCustomVariables" /> class.
        /// </summary>
        /// <param name="template">
        /// Effect template: `french_kiss`, `bodyshake`, or `sexy_me`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpecialEffectsVideosAgentRequestCustomVariables(
            global::ZAI.SpecialEffectsVideosAgentRequestCustomVariablesTemplate template)
        {
            this.Template = template;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentRequestCustomVariables" /> class.
        /// </summary>
        public SpecialEffectsVideosAgentRequestCustomVariables()
        {
        }

    }
}