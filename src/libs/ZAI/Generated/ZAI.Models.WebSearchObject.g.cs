
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebSearchObject
    {
        /// <summary>
        /// Whether to enable search functionality.<br/>
        /// Default is `false`. Set to true to `enable`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Type of search engine.<br/>
        /// Default is `search_pro_jina`. Supports: `search_pro_jina`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.WebSearchObjectSearchEngineJsonConverter))]
        public global::ZAI.WebSearchObjectSearchEngine SearchEngine { get; set; }

        /// <summary>
        /// Force trigger a search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_query")]
        public string? SearchQuery { get; set; }

        /// <summary>
        /// Number of returned results<br/>
        /// Range: `1-50`, max `50` results per search<br/>
        /// Default is `10`<br/>
        /// Supported engines: `search_pro_jina`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Limits search results to specified whitelisted domains. Whitelist: input domains directly (e.g., www.example.com)<br/>
        /// Supported engines: `search_pro_jina`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_domain_filter")]
        public string? SearchDomainFilter { get; set; }

        /// <summary>
        /// Limits search to a specific time range.<br/>
        /// Default is `noLimit`<br/>
        /// Values:<br/>
        /// `oneDay`, within a day<br/>
        /// `oneWeek`, within a week<br/>
        /// `oneMonth`, within a month<br/>
        /// `oneYear`, within a year<br/>
        /// `noLimit`, no limit (default)<br/>
        /// Supported engines: `search_pro_jina`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_recency_filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.WebSearchObjectSearchRecencyFilterJsonConverter))]
        public global::ZAI.WebSearchObjectSearchRecencyFilter? SearchRecencyFilter { get; set; }

        /// <summary>
        /// Number of characters for webpage summaries.<br/>
        /// Default is `medium`<br/>
        /// `medium`: Balanced mode for most queries. 400-600 characters<br/>
        /// `high`: Maximizes context for comprehensive answers, 2500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.WebSearchObjectContentSizeJsonConverter))]
        public global::ZAI.WebSearchObjectContentSize? ContentSize { get; set; }

        /// <summary>
        /// Specifies whether search results are shown before or after model response. Options: `before`, `after`. Default is `after`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_sequence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.WebSearchObjectResultSequenceJsonConverter))]
        public global::ZAI.WebSearchObjectResultSequence? ResultSequence { get; set; }

        /// <summary>
        /// Whether to return search results in the response.<br/>
        /// Default is `false`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_result")]
        public bool? SearchResult { get; set; }

        /// <summary>
        /// Whether to force model response based on search result.<br/>
        /// Default is `false`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_search")]
        public bool? RequireSearch { get; set; }

        /// <summary>
        /// Prompt to customize how search results are processed.<br/>
        /// Default Prompt:<br/>
        /// `You are an intelligent Q&amp;A expert with the ability to synthesize information, recognize time, understand semantics, and clean contradictory data. The current date is {{current_date}}. Use this as the only time reference. Based on the following information, provide a comprehensive and accurate answer to the user's question.Only extract valuable content for the answer. Ensure the answer is timely and authoritative. State the answer directly without citing data sources or internal processes.`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_prompt")]
        public string? SearchPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchObject" /> class.
        /// </summary>
        /// <param name="enable">
        /// Whether to enable search functionality.<br/>
        /// Default is `false`. Set to true to `enable`.
        /// </param>
        /// <param name="searchEngine">
        /// Type of search engine.<br/>
        /// Default is `search_pro_jina`. Supports: `search_pro_jina`.
        /// </param>
        /// <param name="searchQuery">
        /// Force trigger a search
        /// </param>
        /// <param name="count">
        /// Number of returned results<br/>
        /// Range: `1-50`, max `50` results per search<br/>
        /// Default is `10`<br/>
        /// Supported engines: `search_pro_jina`
        /// </param>
        /// <param name="searchDomainFilter">
        /// Limits search results to specified whitelisted domains. Whitelist: input domains directly (e.g., www.example.com)<br/>
        /// Supported engines: `search_pro_jina`
        /// </param>
        /// <param name="searchRecencyFilter">
        /// Limits search to a specific time range.<br/>
        /// Default is `noLimit`<br/>
        /// Values:<br/>
        /// `oneDay`, within a day<br/>
        /// `oneWeek`, within a week<br/>
        /// `oneMonth`, within a month<br/>
        /// `oneYear`, within a year<br/>
        /// `noLimit`, no limit (default)<br/>
        /// Supported engines: `search_pro_jina`
        /// </param>
        /// <param name="contentSize">
        /// Number of characters for webpage summaries.<br/>
        /// Default is `medium`<br/>
        /// `medium`: Balanced mode for most queries. 400-600 characters<br/>
        /// `high`: Maximizes context for comprehensive answers, 2500 characters.
        /// </param>
        /// <param name="resultSequence">
        /// Specifies whether search results are shown before or after model response. Options: `before`, `after`. Default is `after`
        /// </param>
        /// <param name="searchResult">
        /// Whether to return search results in the response.<br/>
        /// Default is `false`
        /// </param>
        /// <param name="requireSearch">
        /// Whether to force model response based on search result.<br/>
        /// Default is `false`
        /// </param>
        /// <param name="searchPrompt">
        /// Prompt to customize how search results are processed.<br/>
        /// Default Prompt:<br/>
        /// `You are an intelligent Q&amp;A expert with the ability to synthesize information, recognize time, understand semantics, and clean contradictory data. The current date is {{current_date}}. Use this as the only time reference. Based on the following information, provide a comprehensive and accurate answer to the user's question.Only extract valuable content for the answer. Ensure the answer is timely and authoritative. State the answer directly without citing data sources or internal processes.`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchObject(
            bool? enable,
            global::ZAI.WebSearchObjectSearchEngine searchEngine,
            string? searchQuery,
            int? count,
            string? searchDomainFilter,
            global::ZAI.WebSearchObjectSearchRecencyFilter? searchRecencyFilter,
            global::ZAI.WebSearchObjectContentSize? contentSize,
            global::ZAI.WebSearchObjectResultSequence? resultSequence,
            bool? searchResult,
            bool? requireSearch,
            string? searchPrompt)
        {
            this.Enable = enable;
            this.SearchEngine = searchEngine;
            this.SearchQuery = searchQuery;
            this.Count = count;
            this.SearchDomainFilter = searchDomainFilter;
            this.SearchRecencyFilter = searchRecencyFilter;
            this.ContentSize = contentSize;
            this.ResultSequence = resultSequence;
            this.SearchResult = searchResult;
            this.RequireSearch = requireSearch;
            this.SearchPrompt = searchPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchObject" /> class.
        /// </summary>
        public WebSearchObject()
        {
        }

    }
}