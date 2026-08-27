
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageGenerationResponseContentFilterItem
    {
        /// <summary>
        /// Safety enforcement stage, including `role = assistant` model inference, `role = user` user input, `role = history` historical context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ImageGenerationResponseContentFilterItemRoleJsonConverter))]
        public global::ZAI.ImageGenerationResponseContentFilterItemRole? Role { get; set; }

        /// <summary>
        /// Severity level `level 0-3`, `level 0` is most severe, `3` is least severe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        public int? Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseContentFilterItem" /> class.
        /// </summary>
        /// <param name="role">
        /// Safety enforcement stage, including `role = assistant` model inference, `role = user` user input, `role = history` historical context.
        /// </param>
        /// <param name="level">
        /// Severity level `level 0-3`, `level 0` is most severe, `3` is least severe.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponseContentFilterItem(
            global::ZAI.ImageGenerationResponseContentFilterItemRole? role,
            int? level)
        {
            this.Role = role;
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseContentFilterItem" /> class.
        /// </summary>
        public ImageGenerationResponseContentFilterItem()
        {
        }

    }
}