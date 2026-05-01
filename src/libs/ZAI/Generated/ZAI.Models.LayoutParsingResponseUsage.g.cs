
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Token usage statistics returned when the model call ends.
    /// </summary>
    public sealed partial class LayoutParsingResponseUsage
    {
        /// <summary>
        /// Number of tokens in user input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public double? PromptTokens { get; set; }

        /// <summary>
        /// Number of output tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public double? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::ZAI.LayoutParsingResponseUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Total number of tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutParsingResponseUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of tokens in user input
        /// </param>
        /// <param name="completionTokens">
        /// Number of output tokens
        /// </param>
        /// <param name="promptTokensDetails"></param>
        /// <param name="totalTokens">
        /// Total number of tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutParsingResponseUsage(
            double? promptTokens,
            double? completionTokens,
            global::ZAI.LayoutParsingResponseUsagePromptTokensDetails? promptTokensDetails,
            int? totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutParsingResponseUsage" /> class.
        /// </summary>
        public LayoutParsingResponseUsage()
        {
        }
    }
}