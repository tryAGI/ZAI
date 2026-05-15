
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionRequest
    {
        /// <summary>
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Base64 encoded audio file. Only one of file_base64 or file needs to be provided (if both are provided, file takes precedence).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_base64")]
        public string? FileBase64 { get; set; }

        /// <summary>
        /// The model ID to invoke.<br/>
        /// Default Value: glm-asr-2512
        /// </summary>
        /// <default>global::ZAI.AudioTranscriptionRequestModel.GlmAsr2512</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.AudioTranscriptionRequestModelJsonConverter))]
        public global::ZAI.AudioTranscriptionRequestModel Model { get; set; } = global::ZAI.AudioTranscriptionRequestModel.GlmAsr2512;

        /// <summary>
        /// In long text scenarios, you can provide previous transcription results as context. Recommended to be less than 8000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Hotword list to improve recognition accuracy for domain-specific vocabulary. Format example: ["person_name","place_name"]. Recommended not to exceed 100 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hotwords")]
        public global::System.Collections.Generic.IList<string>? Hotwords { get; set; }

        /// <summary>
        /// This parameter should be set to `false` or omitted when using synchronous calls. It indicates that the model returns all content at once after generating all content. Default is `false`. If set to `true`, the model will return generated content in chunks via standard `Event Stream`. When the `Event Stream` ends, a `data: [DONE]` message will be returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Unique ID for the end user, 6–128 characters. Avoid using sensitive information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </param>
        /// <param name="filename">
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </param>
        /// <param name="fileBase64">
        /// Base64 encoded audio file. Only one of file_base64 or file needs to be provided (if both are provided, file takes precedence).
        /// </param>
        /// <param name="prompt">
        /// In long text scenarios, you can provide previous transcription results as context. Recommended to be less than 8000 characters.
        /// </param>
        /// <param name="hotwords">
        /// Hotword list to improve recognition accuracy for domain-specific vocabulary. Format example: ["person_name","place_name"]. Recommended not to exceed 100 items.
        /// </param>
        /// <param name="stream">
        /// This parameter should be set to `false` or omitted when using synchronous calls. It indicates that the model returns all content at once after generating all content. Default is `false`. If set to `true`, the model will return generated content in chunks via standard `Event Stream`. When the `Event Stream` ends, a `data: [DONE]` message will be returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestId">
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </param>
        /// <param name="userId">
        /// Unique ID for the end user, 6–128 characters. Avoid using sensitive information.
        /// </param>
        /// <param name="model">
        /// The model ID to invoke.<br/>
        /// Default Value: glm-asr-2512
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionRequest(
            byte[] file,
            string filename,
            string? fileBase64,
            string? prompt,
            global::System.Collections.Generic.IList<string>? hotwords,
            bool? stream,
            string? requestId,
            string? userId,
            global::ZAI.AudioTranscriptionRequestModel model = global::ZAI.AudioTranscriptionRequestModel.GlmAsr2512)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.FileBase64 = fileBase64;
            this.Model = model;
            this.Prompt = prompt;
            this.Hotwords = hotwords;
            this.Stream = stream;
            this.RequestId = requestId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionRequest" /> class.
        /// </summary>
        public AudioTranscriptionRequest()
        {
        }

    }
}