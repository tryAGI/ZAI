
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model ID to invoke.<br/>
    /// Default Value: glm-asr-2512
    /// </summary>
    public enum AudioTranscriptionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        GlmAsr2512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranscriptionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionRequestModel value)
        {
            return value switch
            {
                AudioTranscriptionRequestModel.GlmAsr2512 => "glm-asr-2512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "glm-asr-2512" => AudioTranscriptionRequestModel.GlmAsr2512,
                _ => null,
            };
        }
    }
}