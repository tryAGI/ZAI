
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpecialEffectsVideosAgentRequest
    {
        /// <summary>
        /// Agent ID: `vidu_template_agent`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestAgentIdJsonConverter))]
        public global::ZAI.SpecialEffectsVideosAgentRequestAgentId AgentId { get; set; }

        /// <summary>
        /// User-defined unique ID; used to distinguish requests. Auto-generated if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Session message body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.SpecialEffectsVideosAgentRequestMessage> Messages { get; set; }

        /// <summary>
        /// Agent extension parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_variables")]
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariables? CustomVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Session message body.
        /// </param>
        /// <param name="agentId">
        /// Agent ID: `vidu_template_agent`.
        /// </param>
        /// <param name="requestId">
        /// User-defined unique ID; used to distinguish requests. Auto-generated if omitted.
        /// </param>
        /// <param name="customVariables">
        /// Agent extension parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpecialEffectsVideosAgentRequest(
            global::System.Collections.Generic.IList<global::ZAI.SpecialEffectsVideosAgentRequestMessage> messages,
            global::ZAI.SpecialEffectsVideosAgentRequestAgentId agentId,
            string? requestId,
            global::ZAI.SpecialEffectsVideosAgentRequestCustomVariables? customVariables)
        {
            this.AgentId = agentId;
            this.RequestId = requestId;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.CustomVariables = customVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentRequest" /> class.
        /// </summary>
        public SpecialEffectsVideosAgentRequest()
        {
        }
    }
}