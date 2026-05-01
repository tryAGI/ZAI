
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Resolution parameter<br/>
    /// Default: `1280x720`, Optional: `1280x720`<br/>
    /// Default Value: 1280x720<br/>
    /// Example: 1280x720
    /// </summary>
    public enum ViduImage2VideoRequestVariant1SizeViduq2Image
    {
        /// <summary>
        /// `1280x720`, Optional: `1280x720`
        /// </summary>
        x1280x720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduImage2VideoRequestVariant1SizeViduq2ImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduImage2VideoRequestVariant1SizeViduq2Image value)
        {
            return value switch
            {
                ViduImage2VideoRequestVariant1SizeViduq2Image.x1280x720 => "1280x720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduImage2VideoRequestVariant1SizeViduq2Image? ToEnum(string value)
        {
            return value switch
            {
                "1280x720" => ViduImage2VideoRequestVariant1SizeViduq2Image.x1280x720,
                _ => null,
            };
        }
    }
}