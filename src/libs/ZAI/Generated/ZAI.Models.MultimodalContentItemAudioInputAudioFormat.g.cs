
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Audio file format, supports wav and mp3
    /// </summary>
    public enum MultimodalContentItemAudioInputAudioFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultimodalContentItemAudioInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultimodalContentItemAudioInputAudioFormat value)
        {
            return value switch
            {
                MultimodalContentItemAudioInputAudioFormat.Mp3 => "mp3",
                MultimodalContentItemAudioInputAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultimodalContentItemAudioInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => MultimodalContentItemAudioInputAudioFormat.Mp3,
                "wav" => MultimodalContentItemAudioInputAudioFormat.Wav,
                _ => null,
            };
        }
    }
}