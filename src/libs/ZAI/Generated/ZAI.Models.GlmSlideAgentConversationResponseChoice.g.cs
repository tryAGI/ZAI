
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentConversationResponseChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationResponseChoice" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentConversationResponseChoice(
            global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationResponseChoice" /> class.
        /// </summary>
        public GlmSlideAgentConversationResponseChoice()
        {
        }
    }
}