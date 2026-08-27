
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePaasV4FilesResponse
    {
        /// <summary>
        /// Unique identifier of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public int? Bytes { get; set; }

        /// <summary>
        /// Name of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Purpose of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Timestamp of file creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaasV4FilesResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the uploaded file.
        /// </param>
        /// <param name="object">
        /// Object type.
        /// </param>
        /// <param name="bytes">
        /// File size in bytes.
        /// </param>
        /// <param name="filename">
        /// Name of the uploaded file.
        /// </param>
        /// <param name="purpose">
        /// Purpose of the uploaded file.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of file creation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePaasV4FilesResponse(
            string? id,
            string? @object,
            int? bytes,
            string? filename,
            string? purpose,
            int? createdAt)
        {
            this.Id = id;
            this.Object = @object;
            this.Bytes = bytes;
            this.Filename = filename;
            this.Purpose = purpose;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaasV4FilesResponse" /> class.
        /// </summary>
        public CreatePaasV4FilesResponse()
        {
        }

    }
}