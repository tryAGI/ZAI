#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// This endpoint is used to query the result of an asynchronous request.
        /// </summary>
        /// <param name="acceptLanguage">
        /// Config desired response language for HTTP requests.<br/>
        /// Default Value: en-US,en<br/>
        /// Example: en-US,en
        /// </param>
        /// <param name="id">
        /// Task id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.OneOf<global::ZAI.AsyncVideoGenerationResponse, global::ZAI.AsyncImageGenerationResponse>> GetPaasV4AsyncResultByIdAsync(
            string id,
            global::ZAI.GetPaasV4AsyncResultAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}