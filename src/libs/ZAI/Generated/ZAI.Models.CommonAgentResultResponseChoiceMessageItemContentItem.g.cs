
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommonAgentResultResponseChoiceMessageItemContentItem
    {
        /// <summary>
        /// object type: `video_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// MP4 video URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAgentResultResponseChoiceMessageItemContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// object type: `video_url`.
        /// </param>
        /// <param name="videoUrl">
        /// MP4 video URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonAgentResultResponseChoiceMessageItemContentItem(
            string? type,
            string? videoUrl)
        {
            this.Type = type;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAgentResultResponseChoiceMessageItemContentItem" /> class.
        /// </summary>
        public CommonAgentResultResponseChoiceMessageItemContentItem()
        {
        }
    }
}