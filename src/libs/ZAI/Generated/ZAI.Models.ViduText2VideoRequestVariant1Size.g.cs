
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Resolution parameter<br/>
    /// Default: `1920x1080`, Optional: `1920x1080`<br/>
    /// Example: 1920x1080
    /// </summary>
    public enum ViduText2VideoRequestVariant1Size
    {
        /// <summary>
        /// `1920x1080`, Optional: `1920x1080`
        /// </summary>
        x1920x1080,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduText2VideoRequestVariant1SizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduText2VideoRequestVariant1Size value)
        {
            return value switch
            {
                ViduText2VideoRequestVariant1Size.x1920x1080 => "1920x1080",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduText2VideoRequestVariant1Size? ToEnum(string value)
        {
            return value switch
            {
                "1920x1080" => ViduText2VideoRequestVariant1Size.x1920x1080,
                _ => null,
            };
        }
    }
}