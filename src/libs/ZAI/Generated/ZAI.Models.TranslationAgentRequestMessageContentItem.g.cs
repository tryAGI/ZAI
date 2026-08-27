
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranslationAgentRequestMessageContentItem
    {
        /// <summary>
        /// Supported type: `text`.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::ZAI.TranslationAgentRequestMessageContentItemType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TranslationAgentRequestMessageContentItemTypeJsonConverter))]
        public global::ZAI.TranslationAgentRequestMessageContentItemType Type { get; set; } = global::ZAI.TranslationAgentRequestMessageContentItemType.Text;

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
        /// Initializes a new instance of the <see cref="TranslationAgentRequestMessageContentItem" /> class.
        /// </summary>
        /// <param name="text">
        /// User text input.
        /// </param>
        /// <param name="type">
        /// Supported type: `text`.<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentRequestMessageContentItem(
            string text,
            global::ZAI.TranslationAgentRequestMessageContentItemType type = global::ZAI.TranslationAgentRequestMessageContentItemType.Text)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestMessageContentItem" /> class.
        /// </summary>
        public TranslationAgentRequestMessageContentItem()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TranslationAgentRequestMessageContentItem"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TranslationAgentRequestMessageContentItem FromText(string text)
        {
            return new TranslationAgentRequestMessageContentItem
            {
                Text = text,
            };
        }

    }
}