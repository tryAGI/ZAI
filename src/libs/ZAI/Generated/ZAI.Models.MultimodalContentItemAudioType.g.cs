
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Content type is audio input<br/>
    /// Default Value: input_audio
    /// </summary>
    public enum MultimodalContentItemAudioType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultimodalContentItemAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultimodalContentItemAudioType value)
        {
            return value switch
            {
                MultimodalContentItemAudioType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultimodalContentItemAudioType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => MultimodalContentItemAudioType.InputAudio,
                _ => null,
            };
        }
    }
}