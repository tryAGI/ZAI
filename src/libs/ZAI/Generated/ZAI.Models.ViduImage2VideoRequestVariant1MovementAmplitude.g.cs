
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Motion amplitude<br/>
    /// Default: `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`<br/>
    /// Example: auto
    /// </summary>
    public enum ViduImage2VideoRequestVariant1MovementAmplitude
    {
        /// <summary>
        /// `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`
        /// </summary>
        Auto,
        /// <summary>
        /// `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`
        /// </summary>
        Large,
        /// <summary>
        /// `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`
        /// </summary>
        Medium,
        /// <summary>
        /// `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduImage2VideoRequestVariant1MovementAmplitudeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduImage2VideoRequestVariant1MovementAmplitude value)
        {
            return value switch
            {
                ViduImage2VideoRequestVariant1MovementAmplitude.Auto => "auto",
                ViduImage2VideoRequestVariant1MovementAmplitude.Large => "large",
                ViduImage2VideoRequestVariant1MovementAmplitude.Medium => "medium",
                ViduImage2VideoRequestVariant1MovementAmplitude.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduImage2VideoRequestVariant1MovementAmplitude? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ViduImage2VideoRequestVariant1MovementAmplitude.Auto,
                "large" => ViduImage2VideoRequestVariant1MovementAmplitude.Large,
                "medium" => ViduImage2VideoRequestVariant1MovementAmplitude.Medium,
                "small" => ViduImage2VideoRequestVariant1MovementAmplitude.Small,
                _ => null,
            };
        }
    }
}