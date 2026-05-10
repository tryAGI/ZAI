
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Audio information
    /// </summary>
    public sealed partial class MultimodalContentItemAudioInputAudio
    {
        /// <summary>
        /// Base64 encoding of audio file. Audio duration should not exceed 10 minutes. 1s audio = 12.5 Tokens, rounded up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Audio file format, supports wav and mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.MultimodalContentItemAudioInputAudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.MultimodalContentItemAudioInputAudioFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemAudioInputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64 encoding of audio file. Audio duration should not exceed 10 minutes. 1s audio = 12.5 Tokens, rounded up.
        /// </param>
        /// <param name="format">
        /// Audio file format, supports wav and mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalContentItemAudioInputAudio(
            string data,
            global::ZAI.MultimodalContentItemAudioInputAudioFormat format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemAudioInputAudio" /> class.
        /// </summary>
        public MultimodalContentItemAudioInputAudio()
        {
        }

    }
}