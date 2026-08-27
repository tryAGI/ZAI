
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Default value: if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"<br/>
    /// Example: 1920x1080
    /// </summary>
    public enum CogVideoX3RequestVariant1Size
    {
        /// <summary>
        /// if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"
        /// </summary>
        x1024x1024,
        /// <summary>
        /// if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"
        /// </summary>
        x1080x1920,
        /// <summary>
        /// if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"
        /// </summary>
        x1280x720,
        /// <summary>
        ///
        /// </summary>
        x1920x1080,
        /// <summary>
        /// if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"
        /// </summary>
        x2048x1080,
        /// <summary>
        /// if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"
        /// </summary>
        x3840x2160,
        /// <summary>
        /// if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"
        /// </summary>
        x720x1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CogVideoX3RequestVariant1SizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CogVideoX3RequestVariant1Size value)
        {
            return value switch
            {
                CogVideoX3RequestVariant1Size.x1024x1024 => "1024x1024",
                CogVideoX3RequestVariant1Size.x1080x1920 => "1080x1920",
                CogVideoX3RequestVariant1Size.x1280x720 => "1280x720",
                CogVideoX3RequestVariant1Size.x1920x1080 => "1920x1080",
                CogVideoX3RequestVariant1Size.x2048x1080 => "2048x1080",
                CogVideoX3RequestVariant1Size.x3840x2160 => "3840x2160",
                CogVideoX3RequestVariant1Size.x720x1280 => "720x1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CogVideoX3RequestVariant1Size? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => CogVideoX3RequestVariant1Size.x1024x1024,
                "1080x1920" => CogVideoX3RequestVariant1Size.x1080x1920,
                "1280x720" => CogVideoX3RequestVariant1Size.x1280x720,
                "1920x1080" => CogVideoX3RequestVariant1Size.x1920x1080,
                "2048x1080" => CogVideoX3RequestVariant1Size.x2048x1080,
                "3840x2160" => CogVideoX3RequestVariant1Size.x3840x2160,
                "720x1280" => CogVideoX3RequestVariant1Size.x720x1280,
                _ => null,
            };
        }
    }
}