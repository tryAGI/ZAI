
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationResponse
    {
        /// <summary>
        /// Request creation time, in `Unix` timestamp format, unit is seconds.<br/>
        /// Example: 1760335349
        /// </summary>
        /// <example>1760335349</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Array, containing the generated image `URL`. Currently, the array only contains one image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseDataItem>? Data { get; set; }

        /// <summary>
        /// Array, containing content safety related information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filter")]
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseContentFilterItem>? ContentFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// Request creation time, in `Unix` timestamp format, unit is seconds.<br/>
        /// Example: 1760335349
        /// </param>
        /// <param name="data">
        /// Array, containing the generated image `URL`. Currently, the array only contains one image.
        /// </param>
        /// <param name="contentFilter">
        /// Array, containing content safety related information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponse(
            int? created,
            global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseDataItem>? data,
            global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseContentFilterItem>? contentFilter)
        {
            this.Created = created;
            this.Data = data;
            this.ContentFilter = contentFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        public ImageGenerationResponse()
        {
        }
    }
}