
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Resolution parameter<br/>
    /// Default: `1280x720`, Optional: `1280x720`<br/>
    /// Default Value: 1280x720<br/>
    /// Example: 1280x720
    /// </summary>
    public enum ViduFrames2VideoRequestVariant1SizeVidu2StartEnd
    {
        /// <summary>
        /// `1280x720`, Optional: `1280x720`
        /// </summary>
        x1280x720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduFrames2VideoRequestVariant1SizeVidu2StartEndExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduFrames2VideoRequestVariant1SizeVidu2StartEnd value)
        {
            return value switch
            {
                ViduFrames2VideoRequestVariant1SizeVidu2StartEnd.x1280x720 => "1280x720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduFrames2VideoRequestVariant1SizeVidu2StartEnd? ToEnum(string value)
        {
            return value switch
            {
                "1280x720" => ViduFrames2VideoRequestVariant1SizeVidu2StartEnd.x1280x720,
                _ => null,
            };
        }
    }
}