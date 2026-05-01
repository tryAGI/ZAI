
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommonAgentResultRequest
    {
        /// <summary>
        /// Agent ID: `vidu_template_agent`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Task ID from async response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_id")]
        public string? AsyncId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAgentResultRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID: `vidu_template_agent`.
        /// </param>
        /// <param name="asyncId">
        /// Task ID from async response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonAgentResultRequest(
            string? agentId,
            string? asyncId)
        {
            this.AgentId = agentId;
            this.AsyncId = asyncId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAgentResultRequest" /> class.
        /// </summary>
        public CommonAgentResultRequest()
        {
        }
    }
}