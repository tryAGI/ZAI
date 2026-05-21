
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalContentItemImage
    {
        /// <summary>
        /// Content type is image URL<br/>
        /// Default Value: image_url
        /// </summary>
        /// <default>global::ZAI.MultimodalContentItemImageType.ImageUrl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.MultimodalContentItemImageTypeJsonConverter))]
        public global::ZAI.MultimodalContentItemImageType Type { get; set; } = global::ZAI.MultimodalContentItemImageType.ImageUrl;

        /// <summary>
        /// Image information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.MultimodalContentItemImageImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemImage" /> class.
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
        public MultimodalContentItemImage(
            global::ZAI.MultimodalContentItemImageImageUrl imageUrl,
            global::ZAI.MultimodalContentItemImageType type = global::ZAI.MultimodalContentItemImageType.ImageUrl)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalContentItemImage" /> class.
        /// </summary>
        public MultimodalContentItemImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MultimodalContentItemImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MultimodalContentItemImage FromImageUrl(global::ZAI.MultimodalContentItemImageImageUrl imageUrl)
        {
            return new MultimodalContentItemImage
            {
                ImageUrl = imageUrl,
            };
        }

    }
}