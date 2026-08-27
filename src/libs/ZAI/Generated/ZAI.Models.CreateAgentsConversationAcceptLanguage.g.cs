
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Config desired response language for HTTP requests.<br/>
    /// Default Value: en-US,en<br/>
    /// Example: en-US,en
    /// </summary>
    public enum CreateAgentsConversationAcceptLanguage
    {
        /// <summary>
        ///
        /// </summary>
        EnUS_en,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentsConversationAcceptLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentsConversationAcceptLanguage value)
        {
            return value switch
            {
                CreateAgentsConversationAcceptLanguage.EnUS_en => "en-US,en",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentsConversationAcceptLanguage? ToEnum(string value)
        {
            return value switch
            {
                "en-US,en" => CreateAgentsConversationAcceptLanguage.EnUS_en,
                _ => null,
            };
        }
    }
}