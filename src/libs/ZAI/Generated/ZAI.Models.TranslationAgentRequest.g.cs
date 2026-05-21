
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationAgentRequest
    {
        /// <summary>
        /// Agent ID: `general_translation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TranslationAgentRequestAgentIdJsonConverter))]
        public global::ZAI.TranslationAgentRequestAgentId AgentId { get; set; }

        /// <summary>
        /// False for sync calls (default). True for streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Session message body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_variables")]
        public global::ZAI.TranslationAgentRequestCustomVariables? CustomVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Session message body.
        /// </param>
        /// <param name="agentId">
        /// Agent ID: `general_translation`.
        /// </param>
        /// <param name="stream">
        /// False for sync calls (default). True for streaming.
        /// </param>
        /// <param name="customVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentRequest(
            global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessage> messages,
            global::ZAI.TranslationAgentRequestAgentId agentId,
            bool? stream,
            global::ZAI.TranslationAgentRequestCustomVariables? customVariables)
        {
            this.AgentId = agentId;
            this.Stream = stream;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.CustomVariables = customVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequest" /> class.
        /// </summary>
        public TranslationAgentRequest()
        {
        }

    }
}