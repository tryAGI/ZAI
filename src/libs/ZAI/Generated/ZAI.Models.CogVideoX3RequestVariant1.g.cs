
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CogVideoX3RequestVariant1
    {
        /// <summary>
        /// The model code to be called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1ModelJsonConverter))]
        public global::ZAI.CogVideoX3RequestVariant1Model Model { get; set; }

        /// <summary>
        /// Text description of the video, maximum input length of 512 characters. Either image_url or prompt must be provided, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Output mode, default is `speed`.<br/>
        /// - `quality`: Prioritizes quality, higher generation quality. <br/>
        /// - `speed`: Prioritizes speed, faster generation time, relatively lower quality.<br/>
        /// Example: speed
        /// </summary>
        /// <example>speed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1QualityJsonConverter))]
        public global::ZAI.CogVideoX3RequestVariant1Quality? Quality { get; set; }

        /// <summary>
        /// Whether to generate AI sound effects. Default: `false` (no sound effects).<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_audio")]
        public bool? WithAudio { get; set; }

        /// <summary>
        /// Provide an image based on which content will be generated. If this parameter is passed, the system will operate based on this image. Supports passing images via URL or Base64 encoding. Image requirements: images support `.png`, `.jpeg`, `.jpg` formats; image size: no more than `5M`. Either image_url and prompt can be used, or both can be passed simultaneously.<br/>
        /// First and last frames: supports inputting two images. The first uploaded image is regarded as the first frame, and the second image is regarded as the last frame. The model will generate the video based on the images passed in this parameter.<br/>
        /// First and last frame mode only supports `speed` mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::System.Collections.Generic.IList<global::ZAI.OneOf<string, byte[]>>? ImageUrl { get; set; }

        /// <summary>
        /// Default value: if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"<br/>
        /// Example: 1920x1080
        /// </summary>
        /// <example>1920x1080</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1SizeJsonConverter))]
        public global::ZAI.CogVideoX3RequestVariant1Size? Size { get; set; }

        /// <summary>
        /// Video frame rate (FPS), optional values are `30` or `60`. Default: `30`.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// Video duration, default is 5 seconds, supports `5` and `10` seconds.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CogVideoX3RequestVariant1" /> class.
        /// </summary>
        /// <param name="model">
        /// The model code to be called.
        /// </param>
        /// <param name="prompt">
        /// Text description of the video, maximum input length of 512 characters. Either image_url or prompt must be provided, or both.
        /// </param>
        /// <param name="quality">
        /// Output mode, default is `speed`.<br/>
        /// - `quality`: Prioritizes quality, higher generation quality. <br/>
        /// - `speed`: Prioritizes speed, faster generation time, relatively lower quality.<br/>
        /// Example: speed
        /// </param>
        /// <param name="withAudio">
        /// Whether to generate AI sound effects. Default: `false` (no sound effects).<br/>
        /// Example: false
        /// </param>
        /// <param name="imageUrl">
        /// Provide an image based on which content will be generated. If this parameter is passed, the system will operate based on this image. Supports passing images via URL or Base64 encoding. Image requirements: images support `.png`, `.jpeg`, `.jpg` formats; image size: no more than `5M`. Either image_url and prompt can be used, or both can be passed simultaneously.<br/>
        /// First and last frames: supports inputting two images. The first uploaded image is regarded as the first frame, and the second image is regarded as the last frame. The model will generate the video based on the images passed in this parameter.<br/>
        /// First and last frame mode only supports `speed` mode
        /// </param>
        /// <param name="size">
        /// Default value: if not specified, the short side of the generated video is 1080 by default, and the long side is determined according to the original image ratio. Maximum support for 4K resolution. Resolution options: "1280x720", "720x1280", "1024x1024", "1080x1920", "2048x1080", "3840x2160"<br/>
        /// Example: 1920x1080
        /// </param>
        /// <param name="fps">
        /// Video frame rate (FPS), optional values are `30` or `60`. Default: `30`.<br/>
        /// Example: 30
        /// </param>
        /// <param name="duration">
        /// Video duration, default is 5 seconds, supports `5` and `10` seconds.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CogVideoX3RequestVariant1(
            global::ZAI.CogVideoX3RequestVariant1Model model,
            string? prompt,
            global::ZAI.CogVideoX3RequestVariant1Quality? quality,
            bool? withAudio,
            global::System.Collections.Generic.IList<global::ZAI.OneOf<string, byte[]>>? imageUrl,
            global::ZAI.CogVideoX3RequestVariant1Size? size,
            int? fps,
            int? duration)
        {
            this.Model = model;
            this.Prompt = prompt;
            this.Quality = quality;
            this.WithAudio = withAudio;
            this.ImageUrl = imageUrl;
            this.Size = size;
            this.Fps = fps;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CogVideoX3RequestVariant1" /> class.
        /// </summary>
        public CogVideoX3RequestVariant1()
        {
        }
    }
}