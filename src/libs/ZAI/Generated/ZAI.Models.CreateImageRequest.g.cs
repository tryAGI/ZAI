
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageRequest
    {
        /// <summary>
        /// Model code<br/>
        /// Example: glm-image
        /// </summary>
        /// <example>glm-image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.CreateImageRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.CreateImageRequestModel Model { get; set; }

        /// <summary>
        /// The text description of the image to be generated.<br/>
        /// Example: A cute little kitten.
        /// </summary>
        /// <example>A cute little kitten.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The quality of the generated image. `glm-image` default is `hd`, others model is `standard`. `hd`: Generates a more detailed and rich image with higher overall consistency, but takes about `20` seconds. `standard`: Generates an image quickly, suitable for scenarios with higher requirements for generation speed, takes about `5-10` seconds.<br/>
        /// Default Value: hd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.CreateImageRequestQualityJsonConverter))]
        public global::ZAI.CreateImageRequestQuality? Quality { get; set; }

        /// <summary>
        /// Image size. `glm-image` recommended enum values: `1280x1280` (default), `1568x1056`, `1056x1568`, `1472x1088`, `1088x1472`, `1728x960`, `960x1728`. Custom parameter: Both width and height must be between `1024px-2048px`, and must be divisible by `32`, and the maximum pixel count must not exceed `2^22px`. <br/>
        /// Others model recommended enum values: `1024x1024` (default), `768x1344`, `864x1152`, `1344x768`, `1152x864`, `1440x720`, `720x1440`. Custom parameter: Both width and height must be between `512px-2048px`, and must be divisible by `16`, and the maximum pixel count must not exceed `2^21px`.<br/>
        /// Default Value: 1280x1280<br/>
        /// Example: 1280x1280
        /// </summary>
        /// <example>1280x1280</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Unique ID of the end user, helping the platform intervene in illegal activities, inappropriate content generation, or other abuses. ID length: 6 to 128 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model code<br/>
        /// Example: glm-image
        /// </param>
        /// <param name="prompt">
        /// The text description of the image to be generated.<br/>
        /// Example: A cute little kitten.
        /// </param>
        /// <param name="quality">
        /// The quality of the generated image. `glm-image` default is `hd`, others model is `standard`. `hd`: Generates a more detailed and rich image with higher overall consistency, but takes about `20` seconds. `standard`: Generates an image quickly, suitable for scenarios with higher requirements for generation speed, takes about `5-10` seconds.<br/>
        /// Default Value: hd
        /// </param>
        /// <param name="size">
        /// Image size. `glm-image` recommended enum values: `1280x1280` (default), `1568x1056`, `1056x1568`, `1472x1088`, `1088x1472`, `1728x960`, `960x1728`. Custom parameter: Both width and height must be between `1024px-2048px`, and must be divisible by `32`, and the maximum pixel count must not exceed `2^22px`. <br/>
        /// Others model recommended enum values: `1024x1024` (default), `768x1344`, `864x1152`, `1344x768`, `1152x864`, `1440x720`, `720x1440`. Custom parameter: Both width and height must be between `512px-2048px`, and must be divisible by `16`, and the maximum pixel count must not exceed `2^21px`.<br/>
        /// Default Value: 1280x1280<br/>
        /// Example: 1280x1280
        /// </param>
        /// <param name="userId">
        /// Unique ID of the end user, helping the platform intervene in illegal activities, inappropriate content generation, or other abuses. ID length: 6 to 128 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageRequest(
            global::ZAI.CreateImageRequestModel model,
            string prompt,
            global::ZAI.CreateImageRequestQuality? quality,
            string? size,
            string? userId)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Quality = quality;
            this.Size = size;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        public CreateImageRequest()
        {
        }

    }
}