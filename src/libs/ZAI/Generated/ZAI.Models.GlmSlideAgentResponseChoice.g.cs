
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentResponseChoice
    {
        /// <summary>
        /// Result index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Reason for model inference termination. Can be ‘stop’, ‘tool_calls’, ‘length’, ‘sensitive’, or ‘network_error’.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponseChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// Result index.
        /// </param>
        /// <param name="finishReason">
        /// Reason for model inference termination. Can be ‘stop’, ‘tool_calls’, ‘length’, ‘sensitive’, or ‘network_error’.
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentResponseChoice(
            int? index,
            string? finishReason,
            global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>? message)
        {
            this.Index = index;
            this.FinishReason = finishReason;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponseChoice" /> class.
        /// </summary>
        public GlmSlideAgentResponseChoice()
        {
        }
    }
}