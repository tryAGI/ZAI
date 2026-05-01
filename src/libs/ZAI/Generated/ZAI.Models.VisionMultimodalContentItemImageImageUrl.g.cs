
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Image information
    /// </summary>
    public sealed partial class VisionMultimodalContentItemImageImageUrl
    {
        /// <summary>
        /// Image URL or Base64 encoding. Image size limit is under 5M per image, with pixels not exceeding 6000*6000. GLM-5V GLM4.6V series are limited to 150 sheets, GLM4.5V limit 50 sheets. Supports jpg, png, jpeg formats.
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
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemImageImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Image URL or Base64 encoding. Image size limit is under 5M per image, with pixels not exceeding 6000*6000. GLM-5V GLM4.6V series are limited to 150 sheets, GLM4.5V limit 50 sheets. Supports jpg, png, jpeg formats.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemImageImageUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemImageImageUrl" /> class.
        /// </summary>
        public VisionMultimodalContentItemImageImageUrl()
        {
        }
    }
}