
#nullable enable

namespace ZAI
{
    /// <summary>
    /// File information.
    /// </summary>
    public sealed partial class MultimodalContentItemFileFileUrl
    {
        /// <summary>
        /// File URL address. Supports formats such as PDF and Word, with a maximum of 50 pages for parsing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemFileFileUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// File URL address. Supports formats such as PDF and Word, with a maximum of 50 pages for parsing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalContentItemFileFileUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemFileFileUrl" /> class.
        /// </summary>
        public MultimodalContentItemFileFileUrl()
        {
        }
    }
}