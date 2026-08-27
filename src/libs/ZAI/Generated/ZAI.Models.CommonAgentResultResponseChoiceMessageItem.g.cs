
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommonAgentResultResponseChoiceMessageItem
    {
        /// <summary>
        /// Role: fixed as `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Video file metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAgentResultResponseChoiceMessageItem" /> class.
        /// </summary>
        /// <param name="role">
        /// Role: fixed as `assistant`.
        /// </param>
        /// <param name="content">
        /// Video file metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonAgentResultResponseChoiceMessageItem(
            string? role,
            global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAgentResultResponseChoiceMessageItem" /> class.
        /// </summary>
        public CommonAgentResultResponseChoiceMessageItem()
        {
        }

    }
}