
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentResponseChoiceMessageItem
    {
        /// <summary>
        /// Role: fixed as `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Current role type: thinking、tool、answer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public string? Phase { get; set; }

        /// <summary>
        /// Content metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponseChoiceMessageItem" /> class.
        /// </summary>
        /// <param name="role">
        /// Role: fixed as `assistant`.
        /// </param>
        /// <param name="phase">
        /// Current role type: thinking、tool、answer
        /// </param>
        /// <param name="content">
        /// Content metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentResponseChoiceMessageItem(
            string? role,
            string? phase,
            global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>? content)
        {
            this.Role = role;
            this.Phase = phase;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponseChoiceMessageItem" /> class.
        /// </summary>
        public GlmSlideAgentResponseChoiceMessageItem()
        {
        }

    }
}