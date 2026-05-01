
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentConversationRequest
    {
        /// <summary>
        /// Agent ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Conversation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Custom variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_variables")]
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariables? CustomVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID
        /// </param>
        /// <param name="customVariables">
        /// Custom variables
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentConversationRequest(
            string? agentId,
            string? conversationId,
            global::ZAI.GlmSlideAgentConversationRequestCustomVariables? customVariables)
        {
            this.AgentId = agentId;
            this.ConversationId = conversationId;
            this.CustomVariables = customVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationRequest" /> class.
        /// </summary>
        public GlmSlideAgentConversationRequest()
        {
        }
    }
}