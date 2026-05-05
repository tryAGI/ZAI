
#nullable enable

namespace ZAI
{
    public partial class ZaiClient
    {


        private static readonly global::ZAI.EndPointSecurityRequirement s_CreatePaasV4AsyncImagesGenerationsSecurityRequirement0 =
            new global::ZAI.EndPointSecurityRequirement
            {
                Authorizations = new global::ZAI.EndPointAuthorizationRequirement[]
                {                    new global::ZAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::ZAI.EndPointSecurityRequirement[] s_CreatePaasV4AsyncImagesGenerationsSecurityRequirements =
            new global::ZAI.EndPointSecurityRequirement[]
            {                s_CreatePaasV4AsyncImagesGenerationsSecurityRequirement0,
            };
        partial void PrepareCreatePaasV4AsyncImagesGenerationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ZAI.AsyncCreateImageRequest request);
        partial void PrepareCreatePaasV4AsyncImagesGenerationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ZAI.AsyncCreateImageRequest request);
        partial void ProcessCreatePaasV4AsyncImagesGenerationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePaasV4AsyncImagesGenerationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Image (Async)<br/>
        /// Use the [GLM-Image](/guides/image/glm-image) series models to generate high-quality images from text prompts. Through quick and accurate understanding of user text descriptions, `AI` image expression becomes more precise and personalized. Only supports `GLM-Image` model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ZAI.AsyncResponse> CreatePaasV4AsyncImagesGenerationsAsync(

            global::ZAI.AsyncCreateImageRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreatePaasV4AsyncImagesGenerationsAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate Image (Async)<br/>
        /// Use the [GLM-Image](/guides/image/glm-image) series models to generate high-quality images from text prompts. Through quick and accurate understanding of user text descriptions, `AI` image expression becomes more precise and personalized. Only supports `GLM-Image` model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.AsyncResponse>> CreatePaasV4AsyncImagesGenerationsAsResponseAsync(

            global::ZAI.AsyncCreateImageRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePaasV4AsyncImagesGenerationsArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ZAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreatePaasV4AsyncImagesGenerationsSecurityRequirements,
                operationName: "CreatePaasV4AsyncImagesGenerationsAsync");

            using var __timeoutCancellationTokenSource = global::ZAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::ZAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::ZAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::ZAI.PathBuilder(
                                path: "/paas/v4/async/images/generations",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::ZAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::ZAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreatePaasV4AsyncImagesGenerationsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::ZAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::ZAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createPaasV4AsyncImagesGenerations",
                                methodName: "CreatePaasV4AsyncImagesGenerationsAsync",
                                pathTemplate: "\"/paas/v4/async/images/generations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::ZAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ZAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ZAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createPaasV4AsyncImagesGenerations",
                                methodName: "CreatePaasV4AsyncImagesGenerationsAsync",
                                pathTemplate: "\"/paas/v4/async/images/generations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ZAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ZAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::ZAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::ZAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ZAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createPaasV4AsyncImagesGenerations",
                                methodName: "CreatePaasV4AsyncImagesGenerationsAsync",
                                pathTemplate: "\"/paas/v4/async/images/generations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ZAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreatePaasV4AsyncImagesGenerationsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ZAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ZAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createPaasV4AsyncImagesGenerations",
                                methodName: "CreatePaasV4AsyncImagesGenerationsAsync",
                                pathTemplate: "\"/paas/v4/async/images/generations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ZAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ZAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createPaasV4AsyncImagesGenerations",
                                methodName: "CreatePaasV4AsyncImagesGenerationsAsync",
                                pathTemplate: "\"/paas/v4/async/images/generations\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // The request has failed.
                            if (!__response.IsSuccessStatusCode)
                            {
                                string? __content_default = null;
                                global::System.Exception? __exception_default = null;
                                global::ZAI.Error? __value_default = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_default = global::ZAI.Error.FromJson(__content_default, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_default = global::ZAI.Error.FromJson(__content_default, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_default = __ex;
                                }

                                throw new global::ZAI.ApiException<global::ZAI.Error>(
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_default,
                                    ResponseObject = __value_default,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreatePaasV4AsyncImagesGenerationsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ZAI.AsyncResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ZAI.AutoSDKHttpResponse<global::ZAI.AsyncResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ZAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::ZAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::ZAI.AsyncResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ZAI.AutoSDKHttpResponse<global::ZAI.AsyncResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ZAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::ZAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Generate Image (Async)<br/>
        /// Use the [GLM-Image](/guides/image/glm-image) series models to generate high-quality images from text prompts. Through quick and accurate understanding of user text descriptions, `AI` image expression becomes more precise and personalized. Only supports `GLM-Image` model.
        /// </summary>
        /// <param name="model">
        /// Model code<br/>
        /// Example: glm-image
        /// </param>
        /// <param name="prompt">
        /// The text description of the image to be generated.<br/>
        /// Example: A cute little kitten.
        /// </param>
        /// <param name="quality">
        /// The quality of the generated image. `hd`: Generates a more detailed and rich image with higher overall consistency, takes about `20` seconds.<br/>
        /// Default Value: hd
        /// </param>
        /// <param name="size">
        /// Image size, recommended enum values: `1280x1280` (default), `1568x1056`, `1056x1568`, `1472x1088`, `1088x1472`, `1728x960`, `960x1728`.<br/>
        /// Custom parameter: Both width and height must be between `1024px-2048px`, and must be divisible by `32`, and the maximum pixel count must not exceed `2^22px`.<br/>
        /// Default Value: 1280x1280<br/>
        /// Example: 1280x1280
        /// </param>
        /// <param name="userId">
        /// Unique ID of the end user, helping the platform intervene in illegal activities, inappropriate content generation, or other abuses. ID length: 6 to 128 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ZAI.AsyncResponse> CreatePaasV4AsyncImagesGenerationsAsync(
            string prompt,
            global::ZAI.AsyncCreateImageRequestModel model = default,
            global::ZAI.AsyncCreateImageRequestQuality? quality = default,
            string? size = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ZAI.AsyncCreateImageRequest
            {
                Model = model,
                Prompt = prompt,
                Quality = quality,
                Size = size,
                UserId = userId,
            };

            return await CreatePaasV4AsyncImagesGenerationsAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}