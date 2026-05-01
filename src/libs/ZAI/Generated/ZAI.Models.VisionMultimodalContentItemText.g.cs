
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VisionMultimodalContentItemText
    {
        /// <summary>
        /// Content type is text<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::ZAI.VisionMultimodalContentItemTextType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemTextTypeJsonConverter))]
        public global::ZAI.VisionMultimodalContentItemTextType Type { get; set; } = global::ZAI.VisionMultimodalContentItemTextType.Text;

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
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemText" /> class.
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
        public VisionMultimodalContentItemText(
            string text,
            global::ZAI.VisionMultimodalContentItemTextType type = global::ZAI.VisionMultimodalContentItemTextType.Text)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemText" /> class.
        /// </summary>
        public VisionMultimodalContentItemText()
        {
        }
    }
}