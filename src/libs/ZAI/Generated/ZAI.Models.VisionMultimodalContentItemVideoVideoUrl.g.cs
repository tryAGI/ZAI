
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Video information.
    /// </summary>
    public sealed partial class VisionMultimodalContentItemVideoVideoUrl
    {
        /// <summary>
        /// Video URL address.The video size is limited to within 200 MB, GLM-5V GLM4.6V series are limited to 2 videos, GLM4.5V limit 1 video, and the format supports `mp4`，`mkv`，`mov`.
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
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemVideoVideoUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Video URL address.The video size is limited to within 200 MB, GLM-5V GLM4.6V series are limited to 2 videos, GLM4.5V limit 1 video, and the format supports `mp4`，`mkv`，`mov`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemVideoVideoUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemVideoVideoUrl" /> class.
        /// </summary>
        public VisionMultimodalContentItemVideoVideoUrl()
        {
        }

    }
}