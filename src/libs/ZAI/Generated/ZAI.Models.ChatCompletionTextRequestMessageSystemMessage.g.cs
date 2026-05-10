
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionTextRequestMessageSystemMessage
    {
        /// <summary>
        /// Role of the message author<br/>
        /// Default Value: system
        /// </summary>
        /// <default>global::ZAI.ChatCompletionTextRequestMessageSystemMessageRole.System</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageSystemMessageRoleJsonConverter))]
        public global::ZAI.ChatCompletionTextRequestMessageSystemMessageRole Role { get; set; } = global::ZAI.ChatCompletionTextRequestMessageSystemMessageRole.System;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestMessageSystemMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role">
        /// Role of the message author<br/>
        /// Default Value: system
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTextRequestMessageSystemMessage(
            string content,
            global::ZAI.ChatCompletionTextRequestMessageSystemMessageRole role = global::ZAI.ChatCompletionTextRequestMessageSystemMessageRole.System)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestMessageSystemMessage" /> class.
        /// </summary>
        public ChatCompletionTextRequestMessageSystemMessage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionTextRequestMessageSystemMessage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionTextRequestMessageSystemMessage FromContent(string content)
        {
            return new ChatCompletionTextRequestMessageSystemMessage
            {
                Content = content,
            };
        }

    }
}