
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentConversationResponseChoiceMessageItem
    {
        /// <summary>
        /// Role: fixed as `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Content metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationResponseChoiceMessageItem" /> class.
        /// </summary>
        /// <param name="role">
        /// Role: fixed as `assistant`.
        /// </param>
        /// <param name="content">
        /// Content metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentConversationResponseChoiceMessageItem(
            string? role,
            global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationResponseChoiceMessageItem" /> class.
        /// </summary>
        public GlmSlideAgentConversationResponseChoiceMessageItem()
        {
        }
    }
}