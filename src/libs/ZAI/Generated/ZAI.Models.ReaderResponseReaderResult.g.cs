
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Web reading result
    /// </summary>
    public sealed partial class ReaderResponseReaderResult
    {
        /// <summary>
        /// Main content parsed from the page (body, images, links, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Brief description of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Page title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Original page URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// External resources referenced by the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external")]
        public global::ZAI.ReaderResponseReaderResultExternal? External { get; set; }

        /// <summary>
        /// Page metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::ZAI.ReaderResponseReaderResultMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponseReaderResult" /> class.
        /// </summary>
        /// <param name="content">
        /// Main content parsed from the page (body, images, links, etc.)
        /// </param>
        /// <param name="description">
        /// Brief description of the page
        /// </param>
        /// <param name="title">
        /// Page title
        /// </param>
        /// <param name="url">
        /// Original page URL
        /// </param>
        /// <param name="external">
        /// External resources referenced by the page
        /// </param>
        /// <param name="metadata">
        /// Page metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReaderResponseReaderResult(
            string? content,
            string? description,
            string? title,
            string? url,
            global::ZAI.ReaderResponseReaderResultExternal? external,
            global::ZAI.ReaderResponseReaderResultMetadata? metadata)
        {
            this.Content = content;
            this.Description = description;
            this.Title = title;
            this.Url = url;
            this.External = external;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponseReaderResult" /> class.
        /// </summary>
        public ReaderResponseReaderResult()
        {
        }

    }
}