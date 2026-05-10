
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VisionMultimodalContentItemImage
    {
        /// <summary>
        /// Content type is image URL<br/>
        /// Default Value: image_url
        /// </summary>
        /// <default>global::ZAI.VisionMultimodalContentItemImageType.ImageUrl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemImageTypeJsonConverter))]
        public global::ZAI.VisionMultimodalContentItemImageType Type { get; set; } = global::ZAI.VisionMultimodalContentItemImageType.ImageUrl;

        /// <summary>
        /// Image information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.VisionMultimodalContentItemImageImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Image information
        /// </param>
        /// <param name="type">
        /// Content type is image URL<br/>
        /// Default Value: image_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionMultimodalContentItemImage(
            global::ZAI.VisionMultimodalContentItemImageImageUrl imageUrl,
            global::ZAI.VisionMultimodalContentItemImageType type = global::ZAI.VisionMultimodalContentItemImageType.ImageUrl)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionMultimodalContentItemImage" /> class.
        /// </summary>
        public VisionMultimodalContentItemImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VisionMultimodalContentItemImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VisionMultimodalContentItemImage FromImageUrl(global::ZAI.VisionMultimodalContentItemImageImageUrl imageUrl)
        {
            return new VisionMultimodalContentItemImage
            {
                ImageUrl = imageUrl,
            };
        }

    }
}