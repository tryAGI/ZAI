
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called.
    /// </summary>
    public enum ViduFrames2VideoRequestVariant1Model
    {
        /// <summary>
        ///
        /// </summary>
        Vidu2StartEnd,
        /// <summary>
        ///
        /// </summary>
        Viduq1StartEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduFrames2VideoRequestVariant1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduFrames2VideoRequestVariant1Model value)
        {
            return value switch
            {
                ViduFrames2VideoRequestVariant1Model.Vidu2StartEnd => "vidu2-start-end",
                ViduFrames2VideoRequestVariant1Model.Viduq1StartEnd => "viduq1-start-end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduFrames2VideoRequestVariant1Model? ToEnum(string value)
        {
            return value switch
            {
                "vidu2-start-end" => ViduFrames2VideoRequestVariant1Model.Vidu2StartEnd,
                "viduq1-start-end" => ViduFrames2VideoRequestVariant1Model.Viduq1StartEnd,
                _ => null,
            };
        }
    }
}