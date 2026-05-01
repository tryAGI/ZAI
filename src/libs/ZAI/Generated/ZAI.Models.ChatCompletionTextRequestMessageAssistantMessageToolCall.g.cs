
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionTextRequestMessageAssistantMessageToolCall
    {
        /// <summary>
        /// Tool call ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Tool type, supports web_search, retrieval, function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageAssistantMessageToolCallTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCallType Type { get; set; }

        /// <summary>
        /// Function call information, not empty when type is function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCallFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestMessageAssistantMessageToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// Tool call ID
        /// </param>
        /// <param name="type">
        /// Tool type, supports web_search, retrieval, function
        /// </param>
        /// <param name="function">
        /// Function call information, not empty when type is function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTextRequestMessageAssistantMessageToolCall(
            string id,
            global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCallType type,
            global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCallFunction? function)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestMessageAssistantMessageToolCall" /> class.
        /// </summary>
        public ChatCompletionTextRequestMessageAssistantMessageToolCall()
        {
        }
    }
}