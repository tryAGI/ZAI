
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Image information
    /// </summary>
    public sealed partial class MultimodalContentItemImageImageUrl
    {
        /// <summary>
        /// Image URL or Base64 encoding. Image size limit is under 5M per image, with pixels not exceeding 6000*6000. Supports jpg, png, jpeg formats.
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
        /// Initializes a new instance of the <see cref="MultimodalContentItemImageImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Image URL or Base64 encoding. Image size limit is under 5M per image, with pixels not exceeding 6000*6000. Supports jpg, png, jpeg formats.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalContentItemImageImageUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemImageImageUrl" /> class.
        /// </summary>
        public MultimodalContentItemImageImageUrl()
        {
        }
    }
}