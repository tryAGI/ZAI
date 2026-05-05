#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// Create a chat completion model that generates AI replies for given conversation messages. It supports multimodal inputs (text, images, audio, video, file), offers configurable parameters (like temperature, max tokens, tool use), and supports both streaming and non-streaming output modes.
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
        global::System.Threading.Tasks.Task<global::ZAI.ChatCompletionResponse> CreatePaasV4ChatCompletionsAsync(

            global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequest, global::ZAI.ChatCompletionVisionRequest> request,
            global::ZAI.CreatePaasV4ChatCompletionsAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion model that generates AI replies for given conversation messages. It supports multimodal inputs (text, images, audio, video, file), offers configurable parameters (like temperature, max tokens, tool use), and supports both streaming and non-streaming output modes.
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
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.ChatCompletionResponse>> CreatePaasV4ChatCompletionsAsResponseAsync(

            global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequest, global::ZAI.ChatCompletionVisionRequest> request,
            global::ZAI.CreatePaasV4ChatCompletionsAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion model that generates AI replies for given conversation messages. It supports multimodal inputs (text, images, audio, video, file), offers configurable parameters (like temperature, max tokens, tool use), and supports both streaming and non-streaming output modes.
        /// </summary>
        /// <param name="acceptLanguage">
        /// Config desired response language for HTTP requests.<br/>
        /// Default Value: en-US,en<br/>
        /// Example: en-US,en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.ChatCompletionResponse> CreatePaasV4ChatCompletionsAsync(
            global::ZAI.CreatePaasV4ChatCompletionsAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}