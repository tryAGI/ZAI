
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Token usage statistics.
    /// </summary>
    public sealed partial class TranslationAgentResponseUsage
    {
        /// <summary>
        /// Input tokens count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Output tokens count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Total tokens count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Total number of calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls")]
        public int? TotalCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponseUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Input tokens count.
        /// </param>
        /// <param name="completionTokens">
        /// Output tokens count.
        /// </param>
        /// <param name="totalTokens">
        /// Total tokens count.
        /// </param>
        /// <param name="totalCalls">
        /// Total number of calls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentResponseUsage(
            int? promptTokens,
            int? completionTokens,
            int? totalTokens,
            int? totalCalls)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.TotalCalls = totalCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponseUsage" /> class.
        /// </summary>
        public TranslationAgentResponseUsage()
        {
        }
    }
}