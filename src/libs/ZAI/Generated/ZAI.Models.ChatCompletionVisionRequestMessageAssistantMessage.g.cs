
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Can include tool calls
    /// </summary>
    public sealed partial class ChatCompletionVisionRequestMessageAssistantMessage
    {
        /// <summary>
        /// Role of the message author<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::ZAI.ChatCompletionVisionRequestMessageAssistantMessageRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageAssistantMessageRoleJsonConverter))]
        public global::ZAI.ChatCompletionVisionRequestMessageAssistantMessageRole Role { get; set; } = global::ZAI.ChatCompletionVisionRequestMessageAssistantMessageRole.Assistant;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVisionRequestMessageAssistantMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role">
        /// Role of the message author<br/>
        /// Default Value: assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionVisionRequestMessageAssistantMessage(
            string? content,
            global::ZAI.ChatCompletionVisionRequestMessageAssistantMessageRole role = global::ZAI.ChatCompletionVisionRequestMessageAssistantMessageRole.Assistant)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVisionRequestMessageAssistantMessage" /> class.
        /// </summary>
        public ChatCompletionVisionRequestMessageAssistantMessage()
        {
        }
    }
}