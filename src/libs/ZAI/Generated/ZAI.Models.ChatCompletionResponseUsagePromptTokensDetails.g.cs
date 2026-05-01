
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseUsagePromptTokensDetails
    {
        /// <summary>
        /// Number of tokens served from cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Number of tokens served from cache
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseUsagePromptTokensDetails(
            double? cachedTokens)
        {
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseUsagePromptTokensDetails" /> class.
        /// </summary>
        public ChatCompletionResponseUsagePromptTokensDetails()
        {
        }
    }
}