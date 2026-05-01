
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Style<br/>
    /// Default: `general`<br/>
    /// Optional values: `general` , `anime`<br/>
    /// - `general`: General style, can be controlled using prompts to define the style.<br/>
    /// - `anime`: Anime style, optimized for anime-specific visuals. The style can be controlled using different anime-themed prompts.
    /// </summary>
    public enum ViduText2VideoRequestVariant1Style
    {
        /// <summary>
        /// `general` , `anime`
        /// </summary>
        Anime,
        /// <summary>
        /// `general`
        /// </summary>
        General,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduText2VideoRequestVariant1StyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduText2VideoRequestVariant1Style value)
        {
            return value switch
            {
                ViduText2VideoRequestVariant1Style.Anime => "anime",
                ViduText2VideoRequestVariant1Style.General => "general",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduText2VideoRequestVariant1Style? ToEnum(string value)
        {
            return value switch
            {
                "anime" => ViduText2VideoRequestVariant1Style.Anime,
                "general" => ViduText2VideoRequestVariant1Style.General,
                _ => null,
            };
        }
    }
}