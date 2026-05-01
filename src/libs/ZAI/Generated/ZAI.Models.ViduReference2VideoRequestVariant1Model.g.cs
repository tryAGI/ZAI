
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called.
    /// </summary>
    public enum ViduReference2VideoRequestVariant1Model
    {
        /// <summary>
        /// 
        /// </summary>
        Vidu2Reference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViduReference2VideoRequestVariant1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViduReference2VideoRequestVariant1Model value)
        {
            return value switch
            {
                ViduReference2VideoRequestVariant1Model.Vidu2Reference => "vidu2-reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViduReference2VideoRequestVariant1Model? ToEnum(string value)
        {
            return value switch
            {
                "vidu2-reference" => ViduReference2VideoRequestVariant1Model.Vidu2Reference,
                _ => null,
            };
        }
    }
}