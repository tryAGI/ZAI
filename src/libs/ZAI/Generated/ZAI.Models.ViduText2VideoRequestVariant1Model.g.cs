
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called.
    /// </summary>
    public enum ViduText2VideoRequestVariant1Model
    {
        /// <summary>
        /// 
        /// </summary>
        Viduq1Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduText2VideoRequestVariant1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduText2VideoRequestVariant1Model value)
        {
            return value switch
            {
                ViduText2VideoRequestVariant1Model.Viduq1Text => "viduq1-text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduText2VideoRequestVariant1Model? ToEnum(string value)
        {
            return value switch
            {
                "viduq1-text" => ViduText2VideoRequestVariant1Model.Viduq1Text,
                _ => null,
            };
        }
    }
}