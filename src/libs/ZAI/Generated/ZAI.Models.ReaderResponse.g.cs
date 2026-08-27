
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReaderResponse
    {
        /// <summary>
        /// Task ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Request creation time as a Unix timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Client-provided unique identifier to distinguish requests. If not provided, the platform will generate one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Model code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Web reading result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reader_result")]
        public global::ZAI.ReaderResponseReaderResult? ReaderResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task ID
        /// </param>
        /// <param name="created">
        /// Request creation time as a Unix timestamp in seconds
        /// </param>
        /// <param name="requestId">
        /// Client-provided unique identifier to distinguish requests. If not provided, the platform will generate one.
        /// </param>
        /// <param name="model">
        /// Model code
        /// </param>
        /// <param name="readerResult">
        /// Web reading result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReaderResponse(
            string? id,
            global::System.DateTimeOffset? created,
            string? requestId,
            string? model,
            global::ZAI.ReaderResponseReaderResult? readerResult)
        {
            this.Id = id;
            this.Created = created;
            this.RequestId = requestId;
            this.Model = model;
            this.ReaderResult = readerResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponse" /> class.
        /// </summary>
        public ReaderResponse()
        {
        }

    }
}