
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationAgentResponseChoice
    {
        /// <summary>
        /// Result index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Termination reason: `stop` (normal completion), `tool_calls` (model calls), `length` (token limit exceeded), `sensitive` (content flagged), `network_error` (model inference error).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Model response message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::ZAI.TranslationAgentResponseChoiceMessages? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponseChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// Result index.
        /// </param>
        /// <param name="finishReason">
        /// Termination reason: `stop` (normal completion), `tool_calls` (model calls), `length` (token limit exceeded), `sensitive` (content flagged), `network_error` (model inference error).
        /// </param>
        /// <param name="messages">
        /// Model response message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentResponseChoice(
            int? index,
            string? finishReason,
            global::ZAI.TranslationAgentResponseChoiceMessages? messages)
        {
            this.Index = index;
            this.FinishReason = finishReason;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponseChoice" /> class.
        /// </summary>
        public TranslationAgentResponseChoice()
        {
        }

    }
}