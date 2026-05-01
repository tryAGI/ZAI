
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The quality of the generated image. `glm-image` default is `hd`, others model is `standard`. `hd`: Generates a more detailed and rich image with higher overall consistency, but takes about `20` seconds. `standard`: Generates an image quickly, suitable for scenarios with higher requirements for generation speed, takes about `5-10` seconds.<br/>
    /// Default Value: hd
    /// </summary>
    public enum CreateImageRequestQuality
    {
        /// <summary>
        /// Generates a more detailed and rich image with higher overall consistency, but takes about `20` seconds. `standard`: Generates an image quickly, suitable for scenarios with higher requirements for generation speed, takes about `5-10` seconds.
        /// </summary>
        Hd,
        /// <summary>
        /// Generates a more detailed and rich image with higher overall consistency, but takes about `20` seconds. `standard`: Generates an image quickly, suitable for scenarios with higher requirements for generation speed, takes about `5-10` seconds.
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestQuality value)
        {
            return value switch
            {
                CreateImageRequestQuality.Hd => "hd",
                CreateImageRequestQuality.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "hd" => CreateImageRequestQuality.Hd,
                "standard" => CreateImageRequestQuality.Standard,
                _ => null,
            };
        }
    }
}