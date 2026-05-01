
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalContentItemAudio
    {
        /// <summary>
        /// Content type is audio input<br/>
        /// Default Value: input_audio
        /// </summary>
        /// <default>global::ZAI.MultimodalContentItemAudioType.InputAudio</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.MultimodalContentItemAudioTypeJsonConverter))]
        public global::ZAI.MultimodalContentItemAudioType Type { get; set; } = global::ZAI.MultimodalContentItemAudioType.InputAudio;

        /// <summary>
        /// Audio information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.MultimodalContentItemAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemAudio" /> class.
        /// </summary>
        /// <param name="inputAudio">
        /// Audio information
        /// </param>
        /// <param name="type">
        /// Content type is audio input<br/>
        /// Default Value: input_audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalContentItemAudio(
            global::ZAI.MultimodalContentItemAudioInputAudio inputAudio,
            global::ZAI.MultimodalContentItemAudioType type = global::ZAI.MultimodalContentItemAudioType.InputAudio)
        {
            this.Type = type;
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemAudio" /> class.
        /// </summary>
        public MultimodalContentItemAudio()
        {
        }
    }
}