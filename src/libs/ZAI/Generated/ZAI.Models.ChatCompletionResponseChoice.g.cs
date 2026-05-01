
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseChoice
    {
        /// <summary>
        /// Result index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::ZAI.ChatCompletionResponseMessage? Message { get; set; }

        /// <summary>
        /// Reason for model inference termination. Can be `stop`, `tool_calls`, `length`, `sensitive`, `model_context_window_exceeded` or `network_error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// Result index.
        /// </param>
        /// <param name="message"></param>
        /// <param name="finishReason">
        /// Reason for model inference termination. Can be `stop`, `tool_calls`, `length`, `sensitive`, `model_context_window_exceeded` or `network_error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseChoice(
            int? index,
            global::ZAI.ChatCompletionResponseMessage? message,
            string? finishReason)
        {
            this.Index = index;
            this.Message = message;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        public ChatCompletionResponseChoice()
        {
        }
    }
}