
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionTextRequestMessageToolMessage
    {
        /// <summary>
        /// Role of the message author<br/>
        /// Default Value: tool
        /// </summary>
        /// <default>global::ZAI.ChatCompletionTextRequestMessageToolMessageRole.Tool</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageToolMessageRoleJsonConverter))]
        public global::ZAI.ChatCompletionTextRequestMessageToolMessageRole Role { get; set; } = global::ZAI.ChatCompletionTextRequestMessageToolMessageRole.Tool;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Indicates the tool call ID corresponding to this message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestMessageToolMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolCallId">
        /// Indicates the tool call ID corresponding to this message
        /// </param>
        /// <param name="role">
        /// Role of the message author<br/>
        /// Default Value: tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTextRequestMessageToolMessage(
            string content,
            string toolCallId,
            global::ZAI.ChatCompletionTextRequestMessageToolMessageRole role = global::ZAI.ChatCompletionTextRequestMessageToolMessageRole.Tool)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestMessageToolMessage" /> class.
        /// </summary>
        public ChatCompletionTextRequestMessageToolMessage()
        {
        }

    }
}