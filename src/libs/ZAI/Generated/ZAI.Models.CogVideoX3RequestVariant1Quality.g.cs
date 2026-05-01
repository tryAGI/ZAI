
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Output mode, default is `speed`.<br/>
    /// - `quality`: Prioritizes quality, higher generation quality. <br/>
    /// - `speed`: Prioritizes speed, faster generation time, relatively lower quality.<br/>
    /// Example: speed
    /// </summary>
    public enum CogVideoX3RequestVariant1Quality
    {
        /// <summary>
        /// Prioritizes quality, higher generation quality.
        /// </summary>
        Quality,
        /// <summary>
        /// Prioritizes speed, faster generation time, relatively lower quality.
        /// </summary>
        Speed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CogVideoX3RequestVariant1QualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CogVideoX3RequestVariant1Quality value)
        {
            return value switch
            {
                CogVideoX3RequestVariant1Quality.Quality => "quality",
                CogVideoX3RequestVariant1Quality.Speed => "speed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CogVideoX3RequestVariant1Quality? ToEnum(string value)
        {
            return value switch
            {
                "quality" => CogVideoX3RequestVariant1Quality.Quality,
                "speed" => CogVideoX3RequestVariant1Quality.Speed,
                _ => null,
            };
        }
    }
}