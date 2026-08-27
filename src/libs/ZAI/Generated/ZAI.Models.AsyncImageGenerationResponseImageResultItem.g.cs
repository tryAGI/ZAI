
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsyncImageGenerationResponseImageResultItem
    {
        /// <summary>
        /// Image URL. The temporary link expires after `30` days, please store it promptly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncImageGenerationResponseImageResultItem" /> class.
        /// </summary>
        /// <param name="url">
        /// Image URL. The temporary link expires after `30` days, please store it promptly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncImageGenerationResponseImageResultItem(
            string? url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncImageGenerationResponseImageResultItem" /> class.
        /// </summary>
        public AsyncImageGenerationResponseImageResultItem()
        {
        }

    }
}