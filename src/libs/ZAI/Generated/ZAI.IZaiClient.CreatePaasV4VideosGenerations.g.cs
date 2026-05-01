#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// CogVideoX is a video generation large model developed by Z.AI, equipped with powerful video generation capabilities. Simply inputting text or images allows for effortless video creation.<br/>
        /// Vidu: A high-performance video large model that combines high consistency and high dynamism, with precise semantic understanding and exceptional reasoning speed.
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
        global::System.Threading.Tasks.Task<global::ZAI.VideoResponse> CreatePaasV4VideosGenerationsAsync(

            global::ZAI.OneOf<global::ZAI.CogVideoX3Request?, global::ZAI.ViduText2VideoRequest?, global::ZAI.ViduImage2VideoRequest?, global::ZAI.ViduFrames2VideoRequest?, global::ZAI.ViduReference2VideoRequest?> request,
            global::ZAI.CreatePaasV4VideosGenerationsAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// CogVideoX is a video generation large model developed by Z.AI, equipped with powerful video generation capabilities. Simply inputting text or images allows for effortless video creation.<br/>
        /// Vidu: A high-performance video large model that combines high consistency and high dynamism, with precise semantic understanding and exceptional reasoning speed.
        /// </summary>
        /// <param name="acceptLanguage">
        /// Config desired response language for HTTP requests.<br/>
        /// Default Value: en-US,en<br/>
        /// Example: en-US,en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.VideoResponse> CreatePaasV4VideosGenerationsAsync(
            global::ZAI.CreatePaasV4VideosGenerationsAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}