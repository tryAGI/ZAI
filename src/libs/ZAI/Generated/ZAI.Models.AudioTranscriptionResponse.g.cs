
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioTranscriptionResponse
    {
        /// <summary>
        /// Task ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Request creation time, as a `Unix` timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public long? Created { get; set; }

        /// <summary>
        /// Passed by the client, must be unique. A unique identifier to distinguish each request. If not provided by the client, the platform will generate one by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The complete transcribed content of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task ID
        /// </param>
        /// <param name="created">
        /// Request creation time, as a `Unix` timestamp in seconds.
        /// </param>
        /// <param name="requestId">
        /// Passed by the client, must be unique. A unique identifier to distinguish each request. If not provided by the client, the platform will generate one by default.
        /// </param>
        /// <param name="model">
        /// Model name
        /// </param>
        /// <param name="text">
        /// The complete transcribed content of the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionResponse(
            string? id,
            long? created,
            string? requestId,
            string? model,
            string? text)
        {
            this.Id = id;
            this.Created = created;
            this.RequestId = requestId;
            this.Model = model;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionResponse" /> class.
        /// </summary>
        public AudioTranscriptionResponse()
        {
        }

    }
}