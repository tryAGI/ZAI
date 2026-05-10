
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Page metadata
    /// </summary>
    public sealed partial class ReaderResponseReaderResultMetadata
    {
        /// <summary>
        /// Page keywords
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public string? Keywords { get; set; }

        /// <summary>
        /// Viewport settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewport")]
        public string? Viewport { get; set; }

        /// <summary>
        /// Meta description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Format detection settings, e.g., `telephone=no`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format-detection")]
        public string? FormatDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponseReaderResultMetadata" /> class.
        /// </summary>
        /// <param name="keywords">
        /// Page keywords
        /// </param>
        /// <param name="viewport">
        /// Viewport settings
        /// </param>
        /// <param name="description">
        /// Meta description
        /// </param>
        /// <param name="formatDetection">
        /// Format detection settings, e.g., `telephone=no`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReaderResponseReaderResultMetadata(
            string? keywords,
            string? viewport,
            string? description,
            string? formatDetection)
        {
            this.Keywords = keywords;
            this.Viewport = viewport;
            this.Description = description;
            this.FormatDetection = formatDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponseReaderResultMetadata" /> class.
        /// </summary>
        public ReaderResponseReaderResultMetadata()
        {
        }

    }
}