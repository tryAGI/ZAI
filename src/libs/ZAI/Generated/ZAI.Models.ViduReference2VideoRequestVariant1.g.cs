
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViduReference2VideoRequestVariant1
    {
        /// <summary>
        /// The model code to be called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1ModelJsonConverter))]
        public global::ZAI.ViduReference2VideoRequestVariant1Model Model { get; set; }

        /// <summary>
        /// Text description of the video, maximum input length of 512 characters. Either image_url or prompt must be provided, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Image reference<br/>
        /// Supports input of 1 to 3 images. The model will use the themes from the images provided in this parameter as references to generate a video with consistent subjects.<br/>
        /// 1. Supports image URLs or images encoded in Base64 (ensure accessibility; it is recommended to prioritize using image URLs).<br/>
        /// 2. Supported formats: `png`, `jpeg`, `.jpg`, `webp`.<br/>
        /// 3. Image resolution must not be smaller than `128x128`, and the aspect ratio must be less than `1:4` or `4:1`.<br/>
        /// 4. Image file size must not exceed `50 MB`.<br/>
        /// 5. Note: After Base64 decoding, the byte length must be less than 50 MB, and the encoding must include the proper content-type string, such as `data:image/png;base64,{base64_encode}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::System.Collections.Generic.IList<string>? ImageUrl { get; set; }

        /// <summary>
        /// Video duration parameter.<br/>
        /// Default: `4` , Optional: `4`.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Aspect ratio<br/>
        /// Default: `16:9`, Optional values: `16:9`, `9:16`, `1:1`<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1AspectRatioJsonConverter))]
        public global::ZAI.ViduReference2VideoRequestVariant1AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Resolution parameter<br/>
        /// Default: `1280x720`, Optional: `1280x720`<br/>
        /// Example: 1280x720
        /// </summary>
        /// <example>1280x720</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1SizeJsonConverter))]
        public global::ZAI.ViduReference2VideoRequestVariant1Size? Size { get; set; }

        /// <summary>
        /// Motion amplitude<br/>
        /// Default: `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("movement_amplitude")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1MovementAmplitudeJsonConverter))]
        public global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude? MovementAmplitude { get; set; }

        /// <summary>
        /// Add background music to the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_audio")]
        public bool? WithAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViduReference2VideoRequestVariant1" /> class.
        /// </summary>
        /// <param name="model">
        /// The model code to be called.
        /// </param>
        /// <param name="prompt">
        /// Text description of the video, maximum input length of 512 characters. Either image_url or prompt must be provided, or both.
        /// </param>
        /// <param name="imageUrl">
        /// Image reference<br/>
        /// Supports input of 1 to 3 images. The model will use the themes from the images provided in this parameter as references to generate a video with consistent subjects.<br/>
        /// 1. Supports image URLs or images encoded in Base64 (ensure accessibility; it is recommended to prioritize using image URLs).<br/>
        /// 2. Supported formats: `png`, `jpeg`, `.jpg`, `webp`.<br/>
        /// 3. Image resolution must not be smaller than `128x128`, and the aspect ratio must be less than `1:4` or `4:1`.<br/>
        /// 4. Image file size must not exceed `50 MB`.<br/>
        /// 5. Note: After Base64 decoding, the byte length must be less than 50 MB, and the encoding must include the proper content-type string, such as `data:image/png;base64,{base64_encode}`.
        /// </param>
        /// <param name="duration">
        /// Video duration parameter.<br/>
        /// Default: `4` , Optional: `4`.<br/>
        /// Example: 4
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio<br/>
        /// Default: `16:9`, Optional values: `16:9`, `9:16`, `1:1`<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="size">
        /// Resolution parameter<br/>
        /// Default: `1280x720`, Optional: `1280x720`<br/>
        /// Example: 1280x720
        /// </param>
        /// <param name="movementAmplitude">
        /// Motion amplitude<br/>
        /// Default: `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`<br/>
        /// Example: auto
        /// </param>
        /// <param name="withAudio">
        /// Add background music to the generated video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViduReference2VideoRequestVariant1(
            global::ZAI.ViduReference2VideoRequestVariant1Model model,
            string? prompt,
            global::System.Collections.Generic.IList<string>? imageUrl,
            int? duration,
            global::ZAI.ViduReference2VideoRequestVariant1AspectRatio? aspectRatio,
            global::ZAI.ViduReference2VideoRequestVariant1Size? size,
            global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude? movementAmplitude,
            bool? withAudio)
        {
            this.Model = model;
            this.Prompt = prompt;
            this.ImageUrl = imageUrl;
            this.Duration = duration;
            this.AspectRatio = aspectRatio;
            this.Size = size;
            this.MovementAmplitude = movementAmplitude;
            this.WithAudio = withAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViduReference2VideoRequestVariant1" /> class.
        /// </summary>
        public ViduReference2VideoRequestVariant1()
        {
        }

    }
}