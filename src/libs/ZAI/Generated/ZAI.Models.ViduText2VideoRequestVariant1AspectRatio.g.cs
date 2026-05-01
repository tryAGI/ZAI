
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Aspect ratio<br/>
    /// Default: `16:9`, Optional values: `16:9`, `9:16`, `1:1`<br/>
    /// Example: 16:9
    /// </summary>
    public enum ViduText2VideoRequestVariant1AspectRatio
    {
        /// <summary>
        /// `16:9`, Optional values: `16:9`, `9:16`, `1:1`
        /// </summary>
        x16_9,
        /// <summary>
        /// `16:9`, Optional values: `16:9`, `9:16`, `1:1`
        /// </summary>
        x1_1,
        /// <summary>
        /// `16:9`, Optional values: `16:9`, `9:16`, `1:1`
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduText2VideoRequestVariant1AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduText2VideoRequestVariant1AspectRatio value)
        {
            return value switch
            {
                ViduText2VideoRequestVariant1AspectRatio.x16_9 => "16:9",
                ViduText2VideoRequestVariant1AspectRatio.x1_1 => "1:1",
                ViduText2VideoRequestVariant1AspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduText2VideoRequestVariant1AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ViduText2VideoRequestVariant1AspectRatio.x16_9,
                "1:1" => ViduText2VideoRequestVariant1AspectRatio.x1_1,
                "9:16" => ViduText2VideoRequestVariant1AspectRatio.x9_16,
                _ => null,
            };
        }
    }
}