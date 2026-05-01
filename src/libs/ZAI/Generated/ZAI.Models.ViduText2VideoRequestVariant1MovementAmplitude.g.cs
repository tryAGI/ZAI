
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Motion amplitude<br/>
    /// Default: `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`<br/>
    /// Example: auto
    /// </summary>
    public enum ViduText2VideoRequestVariant1MovementAmplitude
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
    public static class ViduText2VideoRequestVariant1MovementAmplitudeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduText2VideoRequestVariant1MovementAmplitude value)
        {
            return value switch
            {
                ViduText2VideoRequestVariant1MovementAmplitude.Auto => "auto",
                ViduText2VideoRequestVariant1MovementAmplitude.Large => "large",
                ViduText2VideoRequestVariant1MovementAmplitude.Medium => "medium",
                ViduText2VideoRequestVariant1MovementAmplitude.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduText2VideoRequestVariant1MovementAmplitude? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ViduText2VideoRequestVariant1MovementAmplitude.Auto,
                "large" => ViduText2VideoRequestVariant1MovementAmplitude.Large,
                "medium" => ViduText2VideoRequestVariant1MovementAmplitude.Medium,
                "small" => ViduText2VideoRequestVariant1MovementAmplitude.Small,
                _ => null,
            };
        }
    }
}