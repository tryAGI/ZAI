
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentResponse
    {
        /// <summary>
        /// Request ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Conversation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Agent ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Agent output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoice>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::ZAI.GlmSlideAgentResponseError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Request ID
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID
        /// </param>
        /// <param name="agentId">
        /// Agent ID
        /// </param>
        /// <param name="choices">
        /// Agent output.
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentResponse(
            string? id,
            string? conversationId,
            string? agentId,
            global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoice>? choices,
            global::ZAI.GlmSlideAgentResponseError? error)
        {
            this.Id = id;
            this.ConversationId = conversationId;
            this.AgentId = agentId;
            this.Choices = choices;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponse" /> class.
        /// </summary>
        public GlmSlideAgentResponse()
        {
        }
    }
}