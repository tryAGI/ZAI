
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationAgentResponse
    {
        /// <summary>
        /// Task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Agent ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Task status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Model output content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentResponseChoice>? Choices { get; set; }

        /// <summary>
        /// Token usage statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::ZAI.TranslationAgentResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task ID.
        /// </param>
        /// <param name="agentId">
        /// Agent ID.
        /// </param>
        /// <param name="status">
        /// Task status.
        /// </param>
        /// <param name="choices">
        /// Model output content.
        /// </param>
        /// <param name="usage">
        /// Token usage statistics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentResponse(
            string? id,
            string? agentId,
            string? status,
            global::System.Collections.Generic.IList<global::ZAI.TranslationAgentResponseChoice>? choices,
            global::ZAI.TranslationAgentResponseUsage? usage)
        {
            this.Id = id;
            this.AgentId = agentId;
            this.Status = status;
            this.Choices = choices;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponse" /> class.
        /// </summary>
        public TranslationAgentResponse()
        {
        }
    }
}