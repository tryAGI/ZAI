
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommonAgentResultResponse
    {
        /// <summary>
        /// `pending` (processing), `success` (completed), `failed` (failed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Agent ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Asynchronous task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_id")]
        public string? AsyncId { get; set; }

        /// <summary>
        /// Agent output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAgentResultResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// `pending` (processing), `success` (completed), `failed` (failed).
        /// </param>
        /// <param name="agentId">
        /// Agent ID
        /// </param>
        /// <param name="asyncId">
        /// Asynchronous task ID.
        /// </param>
        /// <param name="choices">
        /// Agent output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonAgentResultResponse(
            string? status,
            string? agentId,
            string? asyncId,
            global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoice>? choices)
        {
            this.Status = status;
            this.AgentId = agentId;
            this.AsyncId = asyncId;
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAgentResultResponse" /> class.
        /// </summary>
        public CommonAgentResultResponse()
        {
        }

    }
}