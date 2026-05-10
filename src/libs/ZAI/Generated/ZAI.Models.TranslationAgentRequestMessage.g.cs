
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationAgentRequestMessage
    {
        /// <summary>
        /// User input role: `user`<br/>
        /// Default Value: user<br/>
        /// Example: user
        /// </summary>
        /// <default>global::ZAI.TranslationAgentRequestMessageRole.User</default>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TranslationAgentRequestMessageRoleJsonConverter))]
        public global::ZAI.TranslationAgentRequestMessageRole Role { get; set; } = global::ZAI.TranslationAgentRequestMessageRole.User;

        /// <summary>
        /// Content list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessageContentItem> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestMessage" /> class.
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
        public TranslationAgentRequestMessage(
            global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessageContentItem> content,
            global::ZAI.TranslationAgentRequestMessageRole role = global::ZAI.TranslationAgentRequestMessageRole.User)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestMessage" /> class.
        /// </summary>
        public TranslationAgentRequestMessage()
        {
        }

    }
}