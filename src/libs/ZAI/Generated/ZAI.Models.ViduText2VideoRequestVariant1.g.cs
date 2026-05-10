
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViduText2VideoRequestVariant1
    {
        /// <summary>
        /// The model code to be called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1ModelJsonConverter))]
        public global::ZAI.ViduText2VideoRequestVariant1Model Model { get; set; }

        /// <summary>
        /// Text description of the video, maximum input length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Style<br/>
        /// Default: `general`<br/>
        /// Optional values: `general` , `anime`<br/>
        /// - `general`: General style, can be controlled using prompts to define the style.<br/>
        /// - `anime`: Anime style, optimized for anime-specific visuals. The style can be controlled using different anime-themed prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1StyleJsonConverter))]
        public global::ZAI.ViduText2VideoRequestVariant1Style? Style { get; set; }

        /// <summary>
        /// Video duration parameter.<br/>
        /// Default: `5` , Optional: `5`.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Aspect ratio<br/>
        /// Default: `16:9`, Optional values: `16:9`, `9:16`, `1:1`<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1AspectRatioJsonConverter))]
        public global::ZAI.ViduText2VideoRequestVariant1AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Resolution parameter<br/>
        /// Default: `1920x1080`, Optional: `1920x1080`<br/>
        /// Example: 1920x1080
        /// </summary>
        /// <example>1920x1080</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1SizeJsonConverter))]
        public global::ZAI.ViduText2VideoRequestVariant1Size? Size { get; set; }

        /// <summary>
        /// Motion amplitude<br/>
        /// Default: `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("movement_amplitude")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1MovementAmplitudeJsonConverter))]
        public global::ZAI.ViduText2VideoRequestVariant1MovementAmplitude? MovementAmplitude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViduText2VideoRequestVariant1" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the video, maximum input length of 512 characters.
        /// </param>
        /// <param name="model">
        /// The model code to be called.
        /// </param>
        /// <param name="style">
        /// Style<br/>
        /// Default: `general`<br/>
        /// Optional values: `general` , `anime`<br/>
        /// - `general`: General style, can be controlled using prompts to define the style.<br/>
        /// - `anime`: Anime style, optimized for anime-specific visuals. The style can be controlled using different anime-themed prompts.
        /// </param>
        /// <param name="duration">
        /// Video duration parameter.<br/>
        /// Default: `5` , Optional: `5`.<br/>
        /// Example: 5
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio<br/>
        /// Default: `16:9`, Optional values: `16:9`, `9:16`, `1:1`<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="size">
        /// Resolution parameter<br/>
        /// Default: `1920x1080`, Optional: `1920x1080`<br/>
        /// Example: 1920x1080
        /// </param>
        /// <param name="movementAmplitude">
        /// Motion amplitude<br/>
        /// Default: `auto` , Optional values:  `auto` ,`small` ,`medium` ,`large`<br/>
        /// Example: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViduText2VideoRequestVariant1(
            string prompt,
            global::ZAI.ViduText2VideoRequestVariant1Model model,
            global::ZAI.ViduText2VideoRequestVariant1Style? style,
            int? duration,
            global::ZAI.ViduText2VideoRequestVariant1AspectRatio? aspectRatio,
            global::ZAI.ViduText2VideoRequestVariant1Size? size,
            global::ZAI.ViduText2VideoRequestVariant1MovementAmplitude? movementAmplitude)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Style = style;
            this.Duration = duration;
            this.AspectRatio = aspectRatio;
            this.Size = size;
            this.MovementAmplitude = movementAmplitude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViduText2VideoRequestVariant1" /> class.
        /// </summary>
        public ViduText2VideoRequestVariant1()
        {
        }

    }
}