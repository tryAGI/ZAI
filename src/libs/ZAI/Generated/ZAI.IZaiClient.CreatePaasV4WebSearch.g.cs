#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// The [Web Search](/guides/tools/web-search) is a specialized search engine for large language models. Building upon traditional search engine capabilities like web crawling and ranking, it enhances intent recognition to return results better suited for LLM processing (including webpage titles, URLs, summaries, site names, favicons etc.).
        /// </summary>
        /// <param name="acceptLanguage">
        /// Config desired response language for HTTP requests.<br/>
        /// Default Value: en-US,en<br/>
        /// Example: en-US,en
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.WebSearchResponse> CreatePaasV4WebSearchAsync(

            global::ZAI.WebSearchRequest request,
            global::ZAI.CreatePaasV4WebSearchAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// The [Web Search](/guides/tools/web-search) is a specialized search engine for large language models. Building upon traditional search engine capabilities like web crawling and ranking, it enhances intent recognition to return results better suited for LLM processing (including webpage titles, URLs, summaries, site names, favicons etc.).
        /// </summary>
        /// <param name="acceptLanguage">
        /// Config desired response language for HTTP requests.<br/>
        /// Default Value: en-US,en<br/>
        /// Example: en-US,en
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.WebSearchResponse>> CreatePaasV4WebSearchAsResponseAsync(

            global::ZAI.WebSearchRequest request,
            global::ZAI.CreatePaasV4WebSearchAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// The [Web Search](/guides/tools/web-search) is a specialized search engine for large language models. Building upon traditional search engine capabilities like web crawling and ranking, it enhances intent recognition to return results better suited for LLM processing (including webpage titles, URLs, summaries, site names, favicons etc.).
        /// </summary>
        /// <param name="acceptLanguage">
        /// Config desired response language for HTTP requests.<br/>
        /// Default Value: en-US,en<br/>
        /// Example: en-US,en
        /// </param>
        /// <param name="searchEngine">
        /// The search engine code to call.<br/>
        ///  search-prime: Z.AI Premium Version Search Engine<br/>
        /// Default Value: search-prime<br/>
        /// Example: search-prime
        /// </param>
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
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </param>
        /// <param name="userId">
        /// Unique ID for the end user, 6–128 characters. Avoid using sensitive information.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.WebSearchResponse> CreatePaasV4WebSearchAsync(
            string searchQuery,
            global::ZAI.CreatePaasV4WebSearchAcceptLanguage? acceptLanguage = default,
            global::ZAI.WebSearchRequestSearchEngine searchEngine = global::ZAI.WebSearchRequestSearchEngine.SearchPrime,
            int? count = default,
            string? searchDomainFilter = default,
            global::ZAI.WebSearchRequestSearchRecencyFilter? searchRecencyFilter = default,
            string? requestId = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}