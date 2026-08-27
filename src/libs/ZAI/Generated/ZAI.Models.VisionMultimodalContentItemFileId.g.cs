
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisionMultimodalContentItemFileId
    {
        /// <summary>
        /// Content type is file ID, only GLM-5.3-Flash supported, get the ID via the [File Upload API](/api-reference/agents/file-upload) <br/>
        /// Default Value: file
        /// </summary>
        /// <default>global::ZAI.VisionMultimodalContentItemFileIdType.File</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemFileIdTypeJsonConverter))]
        public global::ZAI.VisionMultimodalContentItemFileIdType Type { get; set; } = global::ZAI.VisionMultimodalContentItemFileIdType.File;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.VisionMultimodalContentItemFileIdFile File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFileId" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type">
        /// Content type is file ID, only GLM-5.3-Flash supported, get the ID via the [File Upload API](/api-reference/agents/file-upload) <br/>
        /// Default Value: file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemFileId(
            global::ZAI.VisionMultimodalContentItemFileIdFile file,
            global::ZAI.VisionMultimodalContentItemFileIdType type = global::ZAI.VisionMultimodalContentItemFileIdType.File)
        {
            this.Type = type;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFileId" /> class.
        /// </summary>
        public VisionMultimodalContentItemFileId()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VisionMultimodalContentItemFileId"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VisionMultimodalContentItemFileId FromFile(global::ZAI.VisionMultimodalContentItemFileIdFile file)
        {
            return new VisionMultimodalContentItemFileId
            {
                File = file,
            };
        }

    }
}