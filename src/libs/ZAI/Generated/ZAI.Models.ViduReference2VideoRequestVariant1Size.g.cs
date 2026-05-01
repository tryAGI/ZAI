
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Resolution parameter<br/>
    /// Default: `1280x720`, Optional: `1280x720`<br/>
    /// Example: 1280x720
    /// </summary>
    public enum ViduReference2VideoRequestVariant1Size
    {
        /// <summary>
        /// `1280x720`, Optional: `1280x720`
        /// </summary>
        x1280x720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduReference2VideoRequestVariant1SizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduReference2VideoRequestVariant1Size value)
        {
            return value switch
            {
                ViduReference2VideoRequestVariant1Size.x1280x720 => "1280x720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduReference2VideoRequestVariant1Size? ToEnum(string value)
        {
            return value switch
            {
                "1280x720" => ViduReference2VideoRequestVariant1Size.x1280x720,
                _ => null,
            };
        }
    }
}