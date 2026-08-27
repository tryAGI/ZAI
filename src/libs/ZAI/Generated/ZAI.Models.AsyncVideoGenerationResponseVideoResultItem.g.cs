
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsyncVideoGenerationResponseVideoResultItem
    {
        /// <summary>
        /// Video URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Video cover URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncVideoGenerationResponseVideoResultItem" /> class.
        /// </summary>
        /// <param name="url">
        /// Video URL.
        /// </param>
        /// <param name="coverImageUrl">
        /// Video cover URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncVideoGenerationResponseVideoResultItem(
            string? url,
            string? coverImageUrl)
        {
            this.Url = url;
            this.CoverImageUrl = coverImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncVideoGenerationResponseVideoResultItem" /> class.
        /// </summary>
        public AsyncVideoGenerationResponseVideoResultItem()
        {
        }

    }
}