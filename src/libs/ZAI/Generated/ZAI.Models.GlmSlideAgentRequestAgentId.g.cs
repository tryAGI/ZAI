
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Agent ID.
    /// </summary>
    public enum GlmSlideAgentRequestAgentId
    {
        /// <summary>
        /// 
        /// </summary>
        SlidesGlmAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlmSlideAgentRequestAgentIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlmSlideAgentRequestAgentId value)
        {
            return value switch
            {
                GlmSlideAgentRequestAgentId.SlidesGlmAgent => "slides_glm_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlmSlideAgentRequestAgentId? ToEnum(string value)
        {
            return value switch
            {
                "slides_glm_agent" => GlmSlideAgentRequestAgentId.SlidesGlmAgent,
                _ => null,
            };
        }
    }
}