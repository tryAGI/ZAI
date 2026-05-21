
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentRequestMessage
    {
        /// <summary>
        /// User input role: `user`<br/>
        /// Default Value: user<br/>
        /// Example: user
        /// </summary>
        /// <default>global::ZAI.GlmSlideAgentRequestMessageRole.User</default>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestMessageRoleJsonConverter))]
        public global::ZAI.GlmSlideAgentRequestMessageRole Role { get; set; } = global::ZAI.GlmSlideAgentRequestMessageRole.User;

        /// <summary>
        /// Content list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessageContentItem> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentRequestMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Content list.
        /// </param>
        /// <param name="role">
        /// User input role: `user`<br/>
        /// Default Value: user<br/>
        /// Example: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentRequestMessage(
            global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessageContentItem> content,
            global::ZAI.GlmSlideAgentRequestMessageRole role = global::ZAI.GlmSlideAgentRequestMessageRole.User)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentRequestMessage" /> class.
        /// </summary>
        public GlmSlideAgentRequestMessage()
        {
        }

    }
}