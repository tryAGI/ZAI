
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The model code to be called.
    /// </summary>
    public enum CogVideoX3RequestVariant1Model
    {
        /// <summary>
        ///
        /// </summary>
        Cogvideox3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CogVideoX3RequestVariant1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CogVideoX3RequestVariant1Model value)
        {
            return value switch
            {
                CogVideoX3RequestVariant1Model.Cogvideox3 => "cogvideox-3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CogVideoX3RequestVariant1Model? ToEnum(string value)
        {
            return value switch
            {
                "cogvideox-3" => CogVideoX3RequestVariant1Model.Cogvideox3,
                _ => null,
            };
        }
    }
}