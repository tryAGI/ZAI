
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Specifies the response format of the model. Defaults to text. Supports two formats:{ "type": "text" } plain text mode, returns natural language text, { "type": "json_object" } JSON mode, returns valid JSON data. When using JSON mode, it’s recommended to clearly request JSON output in the prompt.
    /// </summary>
    public sealed partial class ChatCompletionTextRequestResponseFormat
    {
        /// <summary>
        /// Output format type: text for plain text, json_object for JSON-formatted output.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::ZAI.ChatCompletionTextRequestResponseFormatType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestResponseFormatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.ChatCompletionTextRequestResponseFormatType Type { get; set; } = global::ZAI.ChatCompletionTextRequestResponseFormatType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Output format type: text for plain text, json_object for JSON-formatted output.<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTextRequestResponseFormat(
            global::ZAI.ChatCompletionTextRequestResponseFormatType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestResponseFormat" /> class.
        /// </summary>
        public ChatCompletionTextRequestResponseFormat()
        {
        }

    }
}