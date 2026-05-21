
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchToolSchema
    {
        /// <summary>
        /// Default Value: web_search
        /// </summary>
        /// <default>global::ZAI.WebSearchToolSchemaType.WebSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.WebSearchToolSchemaTypeJsonConverter))]
        public global::ZAI.WebSearchToolSchemaType Type { get; set; } = global::ZAI.WebSearchToolSchemaType.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.WebSearchObject WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolSchema" /> class.
        /// </summary>
        /// <param name="webSearch"></param>
        /// <param name="type">
        /// Default Value: web_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolSchema(
            global::ZAI.WebSearchObject webSearch,
            global::ZAI.WebSearchToolSchemaType type = global::ZAI.WebSearchToolSchemaType.WebSearch)
        {
            this.Type = type;
            this.WebSearch = webSearch ?? throw new global::System.ArgumentNullException(nameof(webSearch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolSchema" /> class.
        /// </summary>
        public WebSearchToolSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WebSearchToolSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebSearchToolSchema FromWebSearch(global::ZAI.WebSearchObject webSearch)
        {
            return new WebSearchToolSchema
            {
                WebSearch = webSearch,
            };
        }

    }
}