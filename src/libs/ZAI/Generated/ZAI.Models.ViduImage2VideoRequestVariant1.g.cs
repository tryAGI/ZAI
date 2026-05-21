
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViduImage2VideoRequestVariant1
    {
        /// <summary>
        /// The model code to be called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.ViduImage2VideoRequestVariant1Model Model { get; set; }

        /// <summary>
        /// Text description of the video, maximum input length of 512 characters. Either image_url or prompt must be provided, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The model will use the image provided in this parameter as the first frame to generate the video.<br/>
        /// Only `1` image is supported.<br/>
        /// Supported formats: `png` , `jpeg` , `jpg` , `webp` .<br/>
        /// Image aspect ratio must be less than `1:4` or `4:1`.<br/>
        /// Image file size must not exceed `50MB`.<br/>
        /// Note: After Base64 decoding, the byte length must be less than 50 MB, and the encoding must include the appropriate content type string (e.g., `data:image/png;base64,{base64_encode}`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.OneOfJsonConverter<string, byte[]>))]
        public global::ZAI.OneOf<string, byte[]>? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image?, global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image?>))]
        public global::ZAI.OneOf<global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image?, global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image?>? Size { get; set; }

        /// <summary>
        /// Motion amplitude<br/>
        /// Default: `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("movement_amplitude")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1MovementAmplitudeJsonConverter))]
        public global::ZAI.ViduImage2VideoRequestVariant1MovementAmplitude? MovementAmplitude { get; set; }

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
        /// Initializes a new instance of the <see cref="ViduImage2VideoRequestVariant1" /> class.
        /// </summary>
        /// <param name="model">
        /// The model code to be called.
        /// </param>
        /// <param name="prompt">
        /// Text description of the video, maximum input length of 512 characters. Either image_url or prompt must be provided, or both.
        /// </param>
        /// <param name="imageUrl">
        /// The model will use the image provided in this parameter as the first frame to generate the video.<br/>
        /// Only `1` image is supported.<br/>
        /// Supported formats: `png` , `jpeg` , `jpg` , `webp` .<br/>
        /// Image aspect ratio must be less than `1:4` or `4:1`.<br/>
        /// Image file size must not exceed `50MB`.<br/>
        /// Note: After Base64 decoding, the byte length must be less than 50 MB, and the encoding must include the appropriate content type string (e.g., `data:image/png;base64,{base64_encode}`).
        /// </param>
        /// <param name="duration"></param>
        /// <param name="size"></param>
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
        public ViduImage2VideoRequestVariant1(
            global::ZAI.ViduImage2VideoRequestVariant1Model model,
            string? prompt,
            global::ZAI.OneOf<string, byte[]>? imageUrl,
            int? duration,
            global::ZAI.OneOf<global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image?, global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image?>? size,
            global::ZAI.ViduImage2VideoRequestVariant1MovementAmplitude? movementAmplitude,
            bool? withAudio)
        {
            this.Model = model;
            this.Prompt = prompt;
            this.ImageUrl = imageUrl;
            this.Duration = duration;
            this.Size = size;
            this.MovementAmplitude = movementAmplitude;
            this.WithAudio = withAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViduImage2VideoRequestVariant1" /> class.
        /// </summary>
        public ViduImage2VideoRequestVariant1()
        {
        }

    }
}