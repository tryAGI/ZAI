
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentConversationResponseChoiceMessageItemContentItem
    {
        /// <summary>
        /// Response Content type: file_url、image_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// CN Tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_cn")]
        public string? TagCn { get; set; }

        /// <summary>
        /// EN Tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_en")]
        public string? TagEn { get; set; }

        /// <summary>
        /// Output file_url content when type is file_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Output image_url content when type is image_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationResponseChoiceMessageItemContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Response Content type: file_url、image_url
        /// </param>
        /// <param name="tagCn">
        /// CN Tag.
        /// </param>
        /// <param name="tagEn">
        /// EN Tag.
        /// </param>
        /// <param name="fileUrl">
        /// Output file_url content when type is file_url
        /// </param>
        /// <param name="imageUrl">
        /// Output image_url content when type is image_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentConversationResponseChoiceMessageItemContentItem(
            string? type,
            string? tagCn,
            string? tagEn,
            string? fileUrl,
            string? imageUrl)
        {
            this.Type = type;
            this.TagCn = tagCn;
            this.TagEn = tagEn;
            this.FileUrl = fileUrl;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationResponseChoiceMessageItemContentItem" /> class.
        /// </summary>
        public GlmSlideAgentConversationResponseChoiceMessageItemContentItem()
        {
        }
    }
}