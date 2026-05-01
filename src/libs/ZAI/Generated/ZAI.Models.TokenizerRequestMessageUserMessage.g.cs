
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizerRequestMessageUserMessage
    {
        /// <summary>
        /// Role of the message author<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::ZAI.TokenizerRequestMessageUserMessageRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TokenizerRequestMessageUserMessageRoleJsonConverter))]
        public global::ZAI.TokenizerRequestMessageUserMessageRole Role { get; set; } = global::ZAI.TokenizerRequestMessageUserMessageRole.User;

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
        /// Initializes a new instance of the <see cref="TokenizerRequestMessageUserMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role">
        /// Role of the message author<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizerRequestMessageUserMessage(
            global::ZAI.OneOf<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string> content,
            global::ZAI.TokenizerRequestMessageUserMessageRole role = global::ZAI.TokenizerRequestMessageUserMessageRole.User)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerRequestMessageUserMessage" /> class.
        /// </summary>
        public TokenizerRequestMessageUserMessage()
        {
        }
    }
}