
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionTextRequestMessageUserMessage
    {
        /// <summary>
        /// Role of the message author<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::ZAI.ChatCompletionTextRequestMessageUserMessageRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageUserMessageRoleJsonConverter))]
        public global::ZAI.ChatCompletionTextRequestMessageUserMessageRole Role { get; set; } = global::ZAI.ChatCompletionTextRequestMessageUserMessageRole.User;

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
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestMessageUserMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role">
        /// Role of the message author<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTextRequestMessageUserMessage(
            string content,
            global::ZAI.ChatCompletionTextRequestMessageUserMessageRole role = global::ZAI.ChatCompletionTextRequestMessageUserMessageRole.User)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequestMessageUserMessage" /> class.
        /// </summary>
        public ChatCompletionTextRequestMessageUserMessage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionTextRequestMessageUserMessage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionTextRequestMessageUserMessage FromContent(string content)
        {
            return new ChatCompletionTextRequestMessageUserMessage
            {
                Content = content,
            };
        }

    }
}