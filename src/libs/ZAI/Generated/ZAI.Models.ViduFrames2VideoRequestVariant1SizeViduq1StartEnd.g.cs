
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Resolution parameter<br/>
    /// Default: `1920x1080`, Optional: `1920x1080`<br/>
    /// Example: 1920x1080
    /// </summary>
    public enum ViduFrames2VideoRequestVariant1SizeViduq1StartEnd
    {
        /// <summary>
        /// `1920x1080`, Optional: `1920x1080`
        /// </summary>
        x1920x1080,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduFrames2VideoRequestVariant1SizeViduq1StartEndExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduFrames2VideoRequestVariant1SizeViduq1StartEnd value)
        {
            return value switch
            {
                ViduFrames2VideoRequestVariant1SizeViduq1StartEnd.x1920x1080 => "1920x1080",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduFrames2VideoRequestVariant1SizeViduq1StartEnd? ToEnum(string value)
        {
            return value switch
            {
                "1920x1080" => ViduFrames2VideoRequestVariant1SizeViduq1StartEnd.x1920x1080,
                _ => null,
            };
        }
    }
}