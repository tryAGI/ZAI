
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalContentItemVideo
    {
        /// <summary>
        /// Content type is video URL<br/>
        /// Default Value: video_url
        /// </summary>
        /// <default>global::ZAI.MultimodalContentItemVideoType.VideoUrl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.MultimodalContentItemVideoTypeJsonConverter))]
        public global::ZAI.MultimodalContentItemVideoType Type { get; set; } = global::ZAI.MultimodalContentItemVideoType.VideoUrl;

        /// <summary>
        /// Video information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.MultimodalContentItemVideoVideoUrl VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// Video information.
        /// </param>
        /// <param name="type">
        /// Content type is video URL<br/>
        /// Default Value: video_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalContentItemVideo(
            global::ZAI.MultimodalContentItemVideoVideoUrl videoUrl,
            global::ZAI.MultimodalContentItemVideoType type = global::ZAI.MultimodalContentItemVideoType.VideoUrl)
        {
            this.Type = type;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemVideo" /> class.
        /// </summary>
        public MultimodalContentItemVideo()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MultimodalContentItemVideo"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MultimodalContentItemVideo FromVideoUrl(global::ZAI.MultimodalContentItemVideoVideoUrl videoUrl)
        {
            return new MultimodalContentItemVideo
            {
                VideoUrl = videoUrl,
            };
        }

    }
}