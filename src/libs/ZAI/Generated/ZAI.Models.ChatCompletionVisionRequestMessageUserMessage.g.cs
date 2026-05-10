
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionVisionRequestMessageUserMessage
    {
        /// <summary>
        /// Role of the message author<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::ZAI.ChatCompletionVisionRequestMessageUserMessageRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageUserMessageRoleJsonConverter))]
        public global::ZAI.ChatCompletionVisionRequestMessageUserMessageRole Role { get; set; } = global::ZAI.ChatCompletionVisionRequestMessageUserMessageRole.User;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.OneOf<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVisionRequestMessageUserMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role">
        /// Role of the message author<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionVisionRequestMessageUserMessage(
            global::ZAI.OneOf<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string> content,
            global::ZAI.ChatCompletionVisionRequestMessageUserMessageRole role = global::ZAI.ChatCompletionVisionRequestMessageUserMessageRole.User)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVisionRequestMessageUserMessage" /> class.
        /// </summary>
        public ChatCompletionVisionRequestMessageUserMessage()
        {
        }

    }
}