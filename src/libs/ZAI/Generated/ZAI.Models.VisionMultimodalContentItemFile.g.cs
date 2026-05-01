
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VisionMultimodalContentItemFile
    {
        /// <summary>
        /// Content type is file URL, not support passing both the `file_url` and `image_url` or `video_url` parameters at the same time.<br/>
        /// Default Value: file_url
        /// </summary>
        /// <default>global::ZAI.VisionMultimodalContentItemFileType.FileUrl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemFileTypeJsonConverter))]
        public global::ZAI.VisionMultimodalContentItemFileType Type { get; set; } = global::ZAI.VisionMultimodalContentItemFileType.FileUrl;

        /// <summary>
        /// File information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.VisionMultimodalContentItemFileFileUrl FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFile" /> class.
        /// </summary>
        /// <param name="fileUrl">
        /// File information.
        /// </param>
        /// <param name="type">
        /// Content type is file URL, not support passing both the `file_url` and `image_url` or `video_url` parameters at the same time.<br/>
        /// Default Value: file_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemFile(
            global::ZAI.VisionMultimodalContentItemFileFileUrl fileUrl,
            global::ZAI.VisionMultimodalContentItemFileType type = global::ZAI.VisionMultimodalContentItemFileType.FileUrl)
        {
            this.Type = type;
            this.FileUrl = fileUrl ?? throw new global::System.ArgumentNullException(nameof(fileUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFile" /> class.
        /// </summary>
        public VisionMultimodalContentItemFile()
        {
        }
    }
}