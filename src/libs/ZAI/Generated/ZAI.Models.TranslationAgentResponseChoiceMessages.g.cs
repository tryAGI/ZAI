
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Model response message.
    /// </summary>
    public sealed partial class TranslationAgentResponseChoiceMessages
    {
        /// <summary>
        /// Dialog role (default: `assistant`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Inference result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::ZAI.TranslationAgentResponseChoiceMessagesContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponseChoiceMessages" /> class.
        /// </summary>
        /// <param name="role">
        /// Dialog role (default: `assistant`).
        /// </param>
        /// <param name="content">
        /// Inference result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentResponseChoiceMessages(
            string? role,
            global::ZAI.TranslationAgentResponseChoiceMessagesContent? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponseChoiceMessages" /> class.
        /// </summary>
        public TranslationAgentResponseChoiceMessages()
        {
        }

    }
}