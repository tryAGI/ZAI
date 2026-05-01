
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizerResponseUsage
    {
        /// <summary>
        /// Prompt tokens in this input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public double? PromptTokens { get; set; }

        /// <summary>
        /// Image tokens in this input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public double? ImageTokens { get; set; }

        /// <summary>
        /// Video tokens in this input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_tokens")]
        public double? VideoTokens { get; set; }

        /// <summary>
        /// Total tokens in this input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public double? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerResponseUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Prompt tokens in this input
        /// </param>
        /// <param name="imageTokens">
        /// Image tokens in this input
        /// </param>
        /// <param name="videoTokens">
        /// Video tokens in this input
        /// </param>
        /// <param name="totalTokens">
        /// Total tokens in this input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizerResponseUsage(
            double? promptTokens,
            double? imageTokens,
            double? videoTokens,
            double? totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.ImageTokens = imageTokens;
            this.VideoTokens = videoTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerResponseUsage" /> class.
        /// </summary>
        public TokenizerResponseUsage()
        {
        }
    }
}