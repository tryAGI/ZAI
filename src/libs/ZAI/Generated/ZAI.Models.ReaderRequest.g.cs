
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReaderRequest
    {
        /// <summary>
        /// The URL to retrieve
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Request timeout in seconds. Default is 20<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Whether to disable caching (true/false). Default is false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_cache")]
        public bool? NoCache { get; set; }

        /// <summary>
        /// Return format (e.g., markdown, text). Default is markdown<br/>
        /// Default Value: markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_format")]
        public string? ReturnFormat { get; set; }

        /// <summary>
        /// Whether to retain images (true/false). Default is true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retain_images")]
        public bool? RetainImages { get; set; }

        /// <summary>
        /// Whether to disable GitHub Flavored Markdown (true/false). Default is false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_gfm")]
        public bool? NoGfm { get; set; }

        /// <summary>
        /// Whether to keep image data URLs (true/false). Default is false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_img_data_url")]
        public bool? KeepImgDataUrl { get; set; }

        /// <summary>
        /// Whether to include image summary (true/false). Default is false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_images_summary")]
        public bool? WithImagesSummary { get; set; }

        /// <summary>
        /// Whether to include links summary (true/false). Default is false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_links_summary")]
        public bool? WithLinksSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to retrieve
        /// </param>
        /// <param name="timeout">
        /// Request timeout in seconds. Default is 20<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="noCache">
        /// Whether to disable caching (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnFormat">
        /// Return format (e.g., markdown, text). Default is markdown<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="retainImages">
        /// Whether to retain images (true/false). Default is true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="noGfm">
        /// Whether to disable GitHub Flavored Markdown (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keepImgDataUrl">
        /// Whether to keep image data URLs (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="withImagesSummary">
        /// Whether to include image summary (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="withLinksSummary">
        /// Whether to include links summary (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReaderRequest(
            string url,
            int? timeout,
            bool? noCache,
            string? returnFormat,
            bool? retainImages,
            bool? noGfm,
            bool? keepImgDataUrl,
            bool? withImagesSummary,
            bool? withLinksSummary)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Timeout = timeout;
            this.NoCache = noCache;
            this.ReturnFormat = returnFormat;
            this.RetainImages = retainImages;
            this.NoGfm = noGfm;
            this.KeepImgDataUrl = keepImgDataUrl;
            this.WithImagesSummary = withImagesSummary;
            this.WithLinksSummary = withLinksSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderRequest" /> class.
        /// </summary>
        public ReaderRequest()
        {
        }

    }
}