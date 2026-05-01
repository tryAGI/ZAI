#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// Web Reader<br/>
        /// Reads and parses the content of the specified URL. Supports selectable return formats, cache control, image retention, and summary options.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.ReaderResponse> CreatePaasV4ReaderAsync(

            global::ZAI.ReaderRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web Reader<br/>
        /// Reads and parses the content of the specified URL. Supports selectable return formats, cache control, image retention, and summary options.
        /// </summary>
        /// <param name="url">
        /// The URL to retrieve
        /// </param>
        /// <param name="timeout">
        /// Request timeout in seconds. Default is 20<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="noCache">
        /// Whether to disable caching (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnFormat">
        /// Return format (e.g., markdown, text). Default is markdown<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="retainImages">
        /// Whether to retain images (true/false). Default is true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="noGfm">
        /// Whether to disable GitHub Flavored Markdown (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keepImgDataUrl">
        /// Whether to keep image data URLs (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="withImagesSummary">
        /// Whether to include image summary (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="withLinksSummary">
        /// Whether to include links summary (true/false). Default is false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.ReaderResponse> CreatePaasV4ReaderAsync(
            string url,
            int? timeout = default,
            bool? noCache = default,
            string? returnFormat = default,
            bool? retainImages = default,
            bool? noGfm = default,
            bool? keepImgDataUrl = default,
            bool? withImagesSummary = default,
            bool? withLinksSummary = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}