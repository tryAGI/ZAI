#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// This endpoint is used to query the agent conversation history.Only support slides_glm_agent
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
        global::System.Threading.Tasks.Task<global::ZAI.GlmSlideAgentConversationResponse> CreateAgentsConversationAsync(

            global::ZAI.GlmSlideAgentConversationRequest request,
            global::ZAI.CreateAgentsConversationAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// This endpoint is used to query the agent conversation history.Only support slides_glm_agent
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
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.GlmSlideAgentConversationResponse>> CreateAgentsConversationAsResponseAsync(

            global::ZAI.GlmSlideAgentConversationRequest request,
            global::ZAI.CreateAgentsConversationAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// This endpoint is used to query the agent conversation history.Only support slides_glm_agent
        /// </summary>
        /// <param name="acceptLanguage">
        /// Config desired response language for HTTP requests.<br/>
        /// Default Value: en-US,en<br/>
        /// Example: en-US,en
        /// </param>
        /// <param name="agentId">
        /// Agent ID
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID
        /// </param>
        /// <param name="customVariables">
        /// Custom variables
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.GlmSlideAgentConversationResponse> CreateAgentsConversationAsync(
            global::ZAI.CreateAgentsConversationAcceptLanguage? acceptLanguage = default,
            string? agentId = default,
            string? conversationId = default,
            global::ZAI.GlmSlideAgentConversationRequestCustomVariables? customVariables = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}