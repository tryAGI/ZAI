
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called.
    /// </summary>
    public enum ViduImage2VideoRequestVariant1Model
    {
        /// <summary>
        /// 
        /// </summary>
        Vidu2Image,
        /// <summary>
        /// 
        /// </summary>
        Viduq1Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduImage2VideoRequestVariant1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduImage2VideoRequestVariant1Model value)
        {
            return value switch
            {
                ViduImage2VideoRequestVariant1Model.Vidu2Image => "vidu2-image",
                ViduImage2VideoRequestVariant1Model.Viduq1Image => "viduq1-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduImage2VideoRequestVariant1Model? ToEnum(string value)
        {
            return value switch
            {
                "vidu2-image" => ViduImage2VideoRequestVariant1Model.Vidu2Image,
                "viduq1-image" => ViduImage2VideoRequestVariant1Model.Viduq1Image,
                _ => null,
            };
        }
    }
}