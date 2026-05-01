
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizerRequestMessageSystemMessage
    {
        /// <summary>
        /// Role of the message author<br/>
        /// Default Value: system
        /// </summary>
        /// <default>global::ZAI.TokenizerRequestMessageSystemMessageRole.System</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TokenizerRequestMessageSystemMessageRoleJsonConverter))]
        public global::ZAI.TokenizerRequestMessageSystemMessageRole Role { get; set; } = global::ZAI.TokenizerRequestMessageSystemMessageRole.System;

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
        /// Initializes a new instance of the <see cref="TokenizerRequestMessageSystemMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role">
        /// Role of the message author<br/>
        /// Default Value: system
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizerRequestMessageSystemMessage(
            string content,
            global::ZAI.TokenizerRequestMessageSystemMessageRole role = global::ZAI.TokenizerRequestMessageSystemMessageRole.System)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerRequestMessageSystemMessage" /> class.
        /// </summary>
        public TokenizerRequestMessageSystemMessage()
        {
        }
    }
}