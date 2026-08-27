
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GlmSlideAgentRequestMessageContentItem
    {
        /// <summary>
        /// Specifies that this content is text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestMessageContentItemTypeJsonConverter))]
        public global::ZAI.GlmSlideAgentRequestMessageContentItemType Type { get; set; }

        /// <summary>
        /// User text input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentRequestMessageContentItem" /> class.
        /// </summary>
        /// <param name="text">
        /// User text input.
        /// </param>
        /// <param name="type">
        /// Specifies that this content is text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentRequestMessageContentItem(
            string text,
            global::ZAI.GlmSlideAgentRequestMessageContentItemType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentRequestMessageContentItem" /> class.
        /// </summary>
        public GlmSlideAgentRequestMessageContentItem()
        {
        }

    }
}