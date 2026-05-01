
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchRequest
    {
        /// <summary>
        /// The search engine code to call.<br/>
        ///  search-prime: Z.AI Premium Version Search Engine<br/>
        /// Default Value: search-prime<br/>
        /// Example: search-prime
        /// </summary>
        /// <default>global::ZAI.WebSearchRequestSearchEngine.SearchPrime</default>
        /// <example>search-prime</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.WebSearchRequestSearchEngineJsonConverter))]
        public global::ZAI.WebSearchRequestSearchEngine SearchEngine { get; set; } = global::ZAI.WebSearchRequestSearchEngine.SearchPrime;

        /// <summary>
        /// The content to be searched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SearchQuery { get; set; }

        /// <summary>
        /// The number of results to return<br/>
        /// Fillable range: `1-50`, maximum `50` results per single search<br/>
        /// Default is `10`<br/>
        /// Supported search engines: <br/>
        /// `search_pro_jina`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Used to limit the scope of search results and only return content from specified whitelist domains.<br/>
        /// Whitelist: Directly enter the domain name (e.g., `www.example.com`)<br/>
        /// Supported search engines: <br/>
        /// `search_pro_jina`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_domain_filter")]
        public string? SearchDomainFilter { get; set; }

        /// <summary>
        /// Search for webpages within a specified time range.<br/>
        /// Default is `noLimit`<br/>
        /// Fillable values:<br/>
        /// `oneDay`: within one day<br/>
        /// `oneWeek`: within one week<br/>
        /// `oneMonth`: within one month<br/>
        /// `oneYear`: within one year<br/>
        /// `noLimit`: no limit (default)<br/>
        /// Supported search engines: <br/>
        /// `search_pro_jina`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_recency_filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.WebSearchRequestSearchRecencyFilterJsonConverter))]
        public global::ZAI.WebSearchRequestSearchRecencyFilter? SearchRecencyFilter { get; set; }

        /// <summary>
        /// User-provided unique identifier for distinguishing requests. If not provided, the platform will generate one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

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
        /// Initializes a new instance of the <see cref="WebSearchRequest" /> class.
        /// </summary>
        /// <param name="searchQuery">
        /// The content to be searched.
        /// </param>
        /// <param name="count">
        /// The number of results to return<br/>
        /// Fillable range: `1-50`, maximum `50` results per single search<br/>
        /// Default is `10`<br/>
        /// Supported search engines: <br/>
        /// `search_pro_jina`.
        /// </param>
        /// <param name="searchDomainFilter">
        /// Used to limit the scope of search results and only return content from specified whitelist domains.<br/>
        /// Whitelist: Directly enter the domain name (e.g., `www.example.com`)<br/>
        /// Supported search engines: <br/>
        /// `search_pro_jina`
        /// </param>
        /// <param name="searchRecencyFilter">
        /// Search for webpages within a specified time range.<br/>
        /// Default is `noLimit`<br/>
        /// Fillable values:<br/>
        /// `oneDay`: within one day<br/>
        /// `oneWeek`: within one week<br/>
        /// `oneMonth`: within one month<br/>
        /// `oneYear`: within one year<br/>
        /// `noLimit`: no limit (default)<br/>
        /// Supported search engines: <br/>
        /// `search_pro_jina`
        /// </param>
        /// <param name="requestId">
        /// User-provided unique identifier for distinguishing requests. If not provided, the platform will generate one.
        /// </param>
        /// <param name="userId">
        /// Unique ID of the end user, helping the platform intervene in illegal activities, inappropriate content generation, or other abuses. ID length: 6 to 128 characters.
        /// </param>
        /// <param name="searchEngine">
        /// The search engine code to call.<br/>
        ///  search-prime: Z.AI Premium Version Search Engine<br/>
        /// Default Value: search-prime<br/>
        /// Example: search-prime
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchRequest(
            string searchQuery,
            int? count,
            string? searchDomainFilter,
            global::ZAI.WebSearchRequestSearchRecencyFilter? searchRecencyFilter,
            string? requestId,
            string? userId,
            global::ZAI.WebSearchRequestSearchEngine searchEngine = global::ZAI.WebSearchRequestSearchEngine.SearchPrime)
        {
            this.SearchEngine = searchEngine;
            this.SearchQuery = searchQuery ?? throw new global::System.ArgumentNullException(nameof(searchQuery));
            this.Count = count;
            this.SearchDomainFilter = searchDomainFilter;
            this.SearchRecencyFilter = searchRecencyFilter;
            this.RequestId = requestId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchRequest" /> class.
        /// </summary>
        public WebSearchRequest()
        {
        }
    }
}