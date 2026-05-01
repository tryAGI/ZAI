
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionVisionRequestMessageSystemMessage
    {
        /// <summary>
        /// Role of the message author<br/>
        /// Default Value: system
        /// </summary>
        /// <default>global::ZAI.ChatCompletionVisionRequestMessageSystemMessageRole.System</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageSystemMessageRoleJsonConverter))]
        public global::ZAI.ChatCompletionVisionRequestMessageSystemMessageRole Role { get; set; } = global::ZAI.ChatCompletionVisionRequestMessageSystemMessageRole.System;

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
        /// Initializes a new instance of the <see cref="ChatCompletionVisionRequestMessageSystemMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role">
        /// Role of the message author<br/>
        /// Default Value: system
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionVisionRequestMessageSystemMessage(
            string content,
            global::ZAI.ChatCompletionVisionRequestMessageSystemMessageRole role = global::ZAI.ChatCompletionVisionRequestMessageSystemMessageRole.System)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVisionRequestMessageSystemMessage" /> class.
        /// </summary>
        public ChatCompletionVisionRequestMessageSystemMessage()
        {
        }
    }
}