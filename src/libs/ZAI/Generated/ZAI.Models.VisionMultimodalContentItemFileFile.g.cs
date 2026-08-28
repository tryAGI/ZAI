
#nullable enable

namespace ZAI
{
    /// <summary>
    /// File content, supports one of `file_id`, `file_url`, or `file_data`. Single file size limit is `50M`.
    /// </summary>
    public sealed partial class VisionMultimodalContentItemFileFile
    {
        /// <summary>
        /// The ID returned by the [File Upload API](/api-reference/agents/file-upload), only GLM-5.3-Flash supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// File URL address. Only GLM-5.3-Flash, GLM-4.6V, GLM-4.5V supported. Supports formats such as pdf, txt, word, jsonl, xlsx, pptx, with a maximum of 50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Base64 file content in the format `data:&lt;MIME&gt;;base64,&lt;BASE64_DATA&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// File name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFileFile" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID returned by the [File Upload API](/api-reference/agents/file-upload), only GLM-5.3-Flash supported.
        /// </param>
        /// <param name="fileUrl">
        /// File URL address. Only GLM-5.3-Flash, GLM-4.6V, GLM-4.5V supported. Supports formats such as pdf, txt, word, jsonl, xlsx, pptx, with a maximum of 50.
        /// </param>
        /// <param name="fileData">
        /// Base64 file content in the format `data:&lt;MIME&gt;;base64,&lt;BASE64_DATA&gt;`.
        /// </param>
        /// <param name="filename">
        /// File name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemFileFile(
            string? fileId,
            string? fileUrl,
            string? fileData,
            string? filename)
        {
            this.FileId = fileId;
            this.FileUrl = fileUrl;
            this.FileData = fileData;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemFileFile" /> class.
        /// </summary>
        public VisionMultimodalContentItemFileFile()
        {
        }

    }
}