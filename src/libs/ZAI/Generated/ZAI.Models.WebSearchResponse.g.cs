
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebSearchResponse
    {
        /// <summary>
        /// Task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Request creation time, Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_result")]
        public global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>? SearchResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task ID.
        /// </param>
        /// <param name="created">
        /// Request creation time, Unix timestamp in seconds.
        /// </param>
        /// <param name="searchResult">
        /// Search results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchResponse(
            string? id,
            global::System.DateTimeOffset? created,
            global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>? searchResult)
        {
            this.Id = id;
            this.Created = created;
            this.SearchResult = searchResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponse" /> class.
        /// </summary>
        public WebSearchResponse()
        {
        }

    }
}