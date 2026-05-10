
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpecialEffectsVideosAgentRequestMessage
    {
        /// <summary>
        /// User input role: `user`<br/>
        /// Default Value: user<br/>
        /// Example: user
        /// </summary>
        /// <default>global::ZAI.SpecialEffectsVideosAgentRequestMessageRole.User</default>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestMessageRoleJsonConverter))]
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageRole Role { get; set; } = global::ZAI.SpecialEffectsVideosAgentRequestMessageRole.User;

        /// <summary>
        /// Content list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText, global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentRequestMessage" /> class.
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
        public SpecialEffectsVideosAgentRequestMessage(
            global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText, global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl>> content,
            global::ZAI.SpecialEffectsVideosAgentRequestMessageRole role = global::ZAI.SpecialEffectsVideosAgentRequestMessageRole.User)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentRequestMessage" /> class.
        /// </summary>
        public SpecialEffectsVideosAgentRequestMessage()
        {
        }

    }
}