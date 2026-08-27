
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Safety enforcement stage, including `role = assistant` model inference, `role = user` user input, `role = history` historical context.
    /// </summary>
    public enum ImageGenerationResponseContentFilterItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        History,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationResponseContentFilterItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationResponseContentFilterItemRole value)
        {
            return value switch
            {
                ImageGenerationResponseContentFilterItemRole.Assistant => "assistant",
                ImageGenerationResponseContentFilterItemRole.History => "history",
                ImageGenerationResponseContentFilterItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationResponseContentFilterItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ImageGenerationResponseContentFilterItemRole.Assistant,
                "history" => ImageGenerationResponseContentFilterItemRole.History,
                "user" => ImageGenerationResponseContentFilterItemRole.User,
                _ => null,
            };
        }
    }
}