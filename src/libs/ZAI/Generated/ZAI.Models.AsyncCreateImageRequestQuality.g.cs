
#nullable enable

namespace ZAI
{
    /// <summary>
    /// The quality of the generated image. `hd`: Generates a more detailed and rich image with higher overall consistency, takes about `20` seconds.<br/>
    /// Default Value: hd
    /// </summary>
    public enum AsyncCreateImageRequestQuality
    {
        /// <summary>
        /// Generates a more detailed and rich image with higher overall consistency, takes about `20` seconds.
        /// </summary>
        Hd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncCreateImageRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncCreateImageRequestQuality value)
        {
            return value switch
            {
                AsyncCreateImageRequestQuality.Hd => "hd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncCreateImageRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "hd" => AsyncCreateImageRequestQuality.Hd,
                _ => null,
            };
        }
    }
}