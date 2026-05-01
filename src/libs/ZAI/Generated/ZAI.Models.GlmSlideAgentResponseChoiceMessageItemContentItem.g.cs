
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentResponseChoiceMessageItemContentItem
    {
        /// <summary>
        /// Response Content type: text、object
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
        /// Output string content when type is text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Output object content when type is object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponseChoiceMessageItemContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Response Content type: text、object
        /// </param>
        /// <param name="tagCn">
        /// CN Tag.
        /// </param>
        /// <param name="tagEn">
        /// EN Tag.
        /// </param>
        /// <param name="text">
        /// Output string content when type is text
        /// </param>
        /// <param name="object">
        /// Output object content when type is object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentResponseChoiceMessageItemContentItem(
            string? type,
            string? tagCn,
            string? tagEn,
            string? text,
            global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItemObject? @object)
        {
            this.Type = type;
            this.TagCn = tagCn;
            this.TagEn = tagEn;
            this.Text = text;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponseChoiceMessageItemContentItem" /> class.
        /// </summary>
        public GlmSlideAgentResponseChoiceMessageItemContentItem()
        {
        }
    }
}