
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentRequest
    {
        /// <summary>
        /// Agent ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestAgentIdJsonConverter))]
        public global::ZAI.GlmSlideAgentRequestAgentId AgentId { get; set; }

        /// <summary>
        /// False for sync calls (default). True for streaming.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Conversation Id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// User-defined unique ID; used to distinguish requests. Auto-generated if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Message body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessage> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Message body.
        /// </param>
        /// <param name="agentId">
        /// Agent ID.
        /// </param>
        /// <param name="stream">
        /// False for sync calls (default). True for streaming.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="conversationId">
        /// Conversation Id.
        /// </param>
        /// <param name="requestId">
        /// User-defined unique ID; used to distinguish requests. Auto-generated if omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentRequest(
            global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessage> messages,
            global::ZAI.GlmSlideAgentRequestAgentId agentId,
            bool? stream,
            string? conversationId,
            string? requestId)
        {
            this.AgentId = agentId;
            this.Stream = stream;
            this.ConversationId = conversationId;
            this.RequestId = requestId;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentRequest" /> class.
        /// </summary>
        public GlmSlideAgentRequest()
        {
        }
    }
}