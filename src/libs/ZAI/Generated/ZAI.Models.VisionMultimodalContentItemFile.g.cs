
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisionMultimodalContentItemFile
    {
        /// <summary>
        /// Content type is file. New unified file type, compatible with the legacy `file_url` type but not recommended for new scenarios. Not support passing both the `file` and `image_url` or `video_url` parameters at the same time.<br/>
        /// Default Value: file
        /// </summary>
        /// <default>global::ZAI.VisionMultimodalContentItemFileType.File</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemFileTypeJsonConverter))]
        public global::ZAI.VisionMultimodalContentItemFileType Type { get; set; } = global::ZAI.VisionMultimodalContentItemFileType.File;

        /// <summary>
        /// File content, supports one of `file_id`, `file_url`, or `file_data`. Single file size limit is `50M`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.VisionMultimodalContentItemFileFile File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFile" /> class.
        /// </summary>
        /// <param name="file">
        /// File content, supports one of `file_id`, `file_url`, or `file_data`. Single file size limit is `50M`.
        /// </param>
        /// <param name="type">
        /// Content type is file. New unified file type, compatible with the legacy `file_url` type but not recommended for new scenarios. Not support passing both the `file` and `image_url` or `video_url` parameters at the same time.<br/>
        /// Default Value: file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemFile(
            global::ZAI.VisionMultimodalContentItemFileFile file,
            global::ZAI.VisionMultimodalContentItemFileType type = global::ZAI.VisionMultimodalContentItemFileType.File)
        {
            this.Type = type;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFile" /> class.
        /// </summary>
        public VisionMultimodalContentItemFile()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VisionMultimodalContentItemFile"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VisionMultimodalContentItemFile FromFile(global::ZAI.VisionMultimodalContentItemFileFile file)
        {
            return new VisionMultimodalContentItemFile
            {
                File = file,
            };
        }

    }
}