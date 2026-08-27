
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisionMultimodalContentItemFileIdFile
    {
        /// <summary>
        /// The ID returned by the file upload API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFileIdFile" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID returned by the file upload API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemFileIdFile(
            string fileId)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFileIdFile" /> class.
        /// </summary>
        public VisionMultimodalContentItemFileIdFile()
        {
        }

    }
}