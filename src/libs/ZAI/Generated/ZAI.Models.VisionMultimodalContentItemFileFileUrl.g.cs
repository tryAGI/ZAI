
#nullable enable

namespace ZAI
{
    /// <summary>
    /// File information.
    /// </summary>
    public sealed partial class VisionMultimodalContentItemFileFileUrl
    {
        /// <summary>
        /// File URL address. Only GLM-5V-Turbo, GLM-4.6V, GLM-4.5V supported. Supports formats such as pdf、txt、word、jsonl、xlsx、pptx, with a maximum of 50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFileFileUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// File URL address. Only GLM-5V-Turbo, GLM-4.6V, GLM-4.5V supported. Supports formats such as pdf、txt、word、jsonl、xlsx、pptx, with a maximum of 50.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemFileFileUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFileFileUrl" /> class.
        /// </summary>
        public VisionMultimodalContentItemFileFileUrl()
        {
        }
    }
}