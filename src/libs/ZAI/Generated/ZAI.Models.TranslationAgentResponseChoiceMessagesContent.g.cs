
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Inference result
    /// </summary>
    public sealed partial class TranslationAgentResponseChoiceMessagesContent
    {
        /// <summary>
        /// Result type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Result content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponseChoiceMessagesContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Result type.
        /// </param>
        /// <param name="text">
        /// Result content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentResponseChoiceMessagesContent(
            string? type,
            string? text)
        {
            this.Type = type;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentResponseChoiceMessagesContent" /> class.
        /// </summary>
        public TranslationAgentResponseChoiceMessagesContent()
        {
        }

    }
}