
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Resolution parameter<br/>
    /// Default: `1920x1080`, Optional: `1920x1080`<br/>
    /// Example: 1920x1080
    /// </summary>
    public enum ViduImage2VideoRequestVariant1SizeViduq1Image
    {
        /// <summary>
        /// `1920x1080`, Optional: `1920x1080`
        /// </summary>
        x1920x1080,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduImage2VideoRequestVariant1SizeViduq1ImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduImage2VideoRequestVariant1SizeViduq1Image value)
        {
            return value switch
            {
                ViduImage2VideoRequestVariant1SizeViduq1Image.x1920x1080 => "1920x1080",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduImage2VideoRequestVariant1SizeViduq1Image? ToEnum(string value)
        {
            return value switch
            {
                "1920x1080" => ViduImage2VideoRequestVariant1SizeViduq1Image.x1920x1080,
                _ => null,
            };
        }
    }
}