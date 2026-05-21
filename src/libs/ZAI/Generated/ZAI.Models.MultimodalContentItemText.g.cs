
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalContentItemText
    {
        /// <summary>
        /// Content type is text<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::ZAI.MultimodalContentItemTextType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.MultimodalContentItemTextTypeJsonConverter))]
        public global::ZAI.MultimodalContentItemTextType Type { get; set; } = global::ZAI.MultimodalContentItemTextType.Text;

        /// <summary>
        /// Text content
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
        /// Initializes a new instance of the <see cref="MultimodalContentItemText" /> class.
        /// </summary>
        /// <param name="text">
        /// Text content
        /// </param>
        /// <param name="type">
        /// Content type is text<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalContentItemText(
            string text,
            global::ZAI.MultimodalContentItemTextType type = global::ZAI.MultimodalContentItemTextType.Text)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemText" /> class.
        /// </summary>
        public MultimodalContentItemText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MultimodalContentItemText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MultimodalContentItemText FromText(string text)
        {
            return new MultimodalContentItemText
            {
                Text = text,
            };
        }

    }
}