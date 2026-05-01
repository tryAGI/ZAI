
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Effect template: `french_kiss`, `bodyshake`, or `sexy_me`.
    /// </summary>
    public enum SpecialEffectsVideosAgentRequestCustomVariablesTemplate
    {
        /// <summary>
        /// `french_kiss`, `bodyshake`, or `sexy_me`.
        /// </summary>
        Bodyshake,
        /// <summary>
        /// `french_kiss`, `bodyshake`, or `sexy_me`.
        /// </summary>
        FrenchKiss,
        /// <summary>
        /// `french_kiss`, `bodyshake`, or `sexy_me`.
        /// </summary>
        SexyMe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpecialEffectsVideosAgentRequestCustomVariablesTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpecialEffectsVideosAgentRequestCustomVariablesTemplate value)
        {
            return value switch
            {
                SpecialEffectsVideosAgentRequestCustomVariablesTemplate.Bodyshake => "bodyshake",
                SpecialEffectsVideosAgentRequestCustomVariablesTemplate.FrenchKiss => "french_kiss",
                SpecialEffectsVideosAgentRequestCustomVariablesTemplate.SexyMe => "sexy_me",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpecialEffectsVideosAgentRequestCustomVariablesTemplate? ToEnum(string value)
        {
            return value switch
            {
                "bodyshake" => SpecialEffectsVideosAgentRequestCustomVariablesTemplate.Bodyshake,
                "french_kiss" => SpecialEffectsVideosAgentRequestCustomVariablesTemplate.FrenchKiss,
                "sexy_me" => SpecialEffectsVideosAgentRequestCustomVariablesTemplate.SexyMe,
                _ => null,
            };
        }
    }
}