
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpecialEffectsVideosAgentRequestMessageContentItemImageUrl
    {
        /// <summary>
        /// Specifies that this content is an image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlTypeJsonConverter))]
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType Type { get; set; }

        /// <summary>
        /// Image URL input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentRequestMessageContentItemImageUrl" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Image URL input.
        /// </param>
        /// <param name="type">
        /// Specifies that this content is an image URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpecialEffectsVideosAgentRequestMessageContentItemImageUrl(
            string imageUrl,
            global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType type)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentRequestMessageContentItemImageUrl" /> class.
        /// </summary>
        public SpecialEffectsVideosAgentRequestMessageContentItemImageUrl()
        {
        }
    }
}