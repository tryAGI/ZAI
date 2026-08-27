
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpecialEffectsVideosAgentError
    {
        /// <summary>
        /// Status: `pending` (task created), `failed` (task creation failed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Agent ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::ZAI.SpecialEffectsVideosAgentErrorError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentError" /> class.
        /// </summary>
        /// <param name="status">
        /// Status: `pending` (task created), `failed` (task creation failed).
        /// </param>
        /// <param name="agentId">
        /// Agent ID
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpecialEffectsVideosAgentError(
            string? status,
            string? agentId,
            global::ZAI.SpecialEffectsVideosAgentErrorError? error)
        {
            this.Status = status;
            this.AgentId = agentId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentError" /> class.
        /// </summary>
        public SpecialEffectsVideosAgentError()
        {
        }

    }
}