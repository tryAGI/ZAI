
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MultimodalContentItemFile
    {
        /// <summary>
        /// Content type is file URL<br/>
        /// Default Value: file_url
        /// </summary>
        /// <default>global::ZAI.MultimodalContentItemFileType.FileUrl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.MultimodalContentItemFileTypeJsonConverter))]
        public global::ZAI.MultimodalContentItemFileType Type { get; set; } = global::ZAI.MultimodalContentItemFileType.FileUrl;

        /// <summary>
        /// File information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.MultimodalContentItemFileFileUrl FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemFile" /> class.
        /// </summary>
        /// <param name="fileUrl">
        /// File information.
        /// </param>
        /// <param name="type">
        /// Content type is file URL<br/>
        /// Default Value: file_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalContentItemFile(
            global::ZAI.MultimodalContentItemFileFileUrl fileUrl,
            global::ZAI.MultimodalContentItemFileType type = global::ZAI.MultimodalContentItemFileType.FileUrl)
        {
            this.Type = type;
            this.FileUrl = fileUrl ?? throw new global::System.ArgumentNullException(nameof(fileUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemFile" /> class.
        /// </summary>
        public MultimodalContentItemFile()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MultimodalContentItemFile"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MultimodalContentItemFile FromFileUrl(global::ZAI.MultimodalContentItemFileFileUrl fileUrl)
        {
            return new MultimodalContentItemFile
            {
                FileUrl = fileUrl,
            };
        }

    }
}