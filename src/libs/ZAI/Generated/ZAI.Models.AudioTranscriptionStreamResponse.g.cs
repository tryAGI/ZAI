
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioTranscriptionStreamResponse
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
        /// Model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Audio transcription event type. `transcript.text.delta` indicates transcription in progress, `transcript.text.done` indicates transcription completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Incremental audio transcription information returned by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionStreamResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task ID
        /// </param>
        /// <param name="created">
        /// Request creation time, as a `Unix` timestamp in seconds.
        /// </param>
        /// <param name="model">
        /// Model name
        /// </param>
        /// <param name="type">
        /// Audio transcription event type. `transcript.text.delta` indicates transcription in progress, `transcript.text.done` indicates transcription completed.
        /// </param>
        /// <param name="delta">
        /// Incremental audio transcription information returned by the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionStreamResponse(
            string? id,
            long? created,
            string? model,
            string? type,
            string? delta)
        {
            this.Id = id;
            this.Created = created;
            this.Model = model;
            this.Type = type;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionStreamResponse" /> class.
        /// </summary>
        public AudioTranscriptionStreamResponse()
        {
        }

    }
}