
#nullable enable

namespace ZAI
{
    public partial class ZaiClient
    {


        private static readonly global::ZAI.EndPointSecurityRequirement s_CreatePaasV4LayoutParsingSecurityRequirement0 =
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
        private static readonly global::ZAI.EndPointSecurityRequirement[] s_CreatePaasV4LayoutParsingSecurityRequirements =
            new global::ZAI.EndPointSecurityRequirement[]
            {                s_CreatePaasV4LayoutParsingSecurityRequirement0,
            };
        partial void PrepareCreatePaasV4LayoutParsingArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ZAI.LayoutParsingRequest request);
        partial void PrepareCreatePaasV4LayoutParsingRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ZAI.LayoutParsingRequest request);
        partial void ProcessCreatePaasV4LayoutParsingResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePaasV4LayoutParsingResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Layout Parsing<br/>
        /// Use the [GLM-OCR](/guides/vlm/glm-ocr) model to parse the layout of documents and images and extract text content. Support OCR recognition of images and PDF documents, returning detailed layout information and visualization results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ZAI.LayoutParsingResponse> CreatePaasV4LayoutParsingAsync(

            global::ZAI.LayoutParsingRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreatePaasV4LayoutParsingAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Layout Parsing<br/>
        /// Use the [GLM-OCR](/guides/vlm/glm-ocr) model to parse the layout of documents and images and extract text content. Support OCR recognition of images and PDF documents, returning detailed layout information and visualization results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.LayoutParsingResponse>> CreatePaasV4LayoutParsingAsResponseAsync(

            global::ZAI.LayoutParsingRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePaasV4LayoutParsingArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ZAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreatePaasV4LayoutParsingSecurityRequirements,
                operationName: "CreatePaasV4LayoutParsingAsync");

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
                                path: "/paas/v4/layout_parsing",
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
                PrepareCreatePaasV4LayoutParsingRequest(
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
                                operationId: "createPaasV4LayoutParsing",
                                methodName: "CreatePaasV4LayoutParsingAsync",
                                pathTemplate: "\"/paas/v4/layout_parsing\"",
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
                                operationId: "createPaasV4LayoutParsing",
                                methodName: "CreatePaasV4LayoutParsingAsync",
                                pathTemplate: "\"/paas/v4/layout_parsing\"",
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
                                operationId: "createPaasV4LayoutParsing",
                                methodName: "CreatePaasV4LayoutParsingAsync",
                                pathTemplate: "\"/paas/v4/layout_parsing\"",
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
                ProcessCreatePaasV4LayoutParsingResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ZAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ZAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createPaasV4LayoutParsing",
                                methodName: "CreatePaasV4LayoutParsingAsync",
                                pathTemplate: "\"/paas/v4/layout_parsing\"",
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
                                operationId: "createPaasV4LayoutParsing",
                                methodName: "CreatePaasV4LayoutParsingAsync",
                                pathTemplate: "\"/paas/v4/layout_parsing\"",
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
                            // Request failed.
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


                                throw global::ZAI.ApiException<global::ZAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    responseBody: __content_default,
                                    responseObject: __value_default,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreatePaasV4LayoutParsingResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ZAI.LayoutParsingResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ZAI.AutoSDKHttpResponse<global::ZAI.LayoutParsingResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ZAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::ZAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::ZAI.LayoutParsingResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ZAI.AutoSDKHttpResponse<global::ZAI.LayoutParsingResponse>(
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

                                    throw global::ZAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Layout Parsing<br/>
        /// Use the [GLM-OCR](/guides/vlm/glm-ocr) model to parse the layout of documents and images and extract text content. Support OCR recognition of images and PDF documents, returning detailed layout information and visualization results.
        /// </summary>
        /// <param name="model">
        /// Model code: `glm-ocr`<br/>
        /// Example: glm-ocr
        /// </param>
        /// <param name="file">
        /// Image or PDF document to be recognized, supports URL and base64. Supported image formats: PDF, JPG, PNG. Single image ≤10MB, PDF ≤50MB, maximum support 30 pages<br/>
        /// Example: https://cdn.bigmodel.cn/static/logo/introduction.png
        /// </param>
        /// <param name="returnCropImages">
        /// Whether to return screenshot information<br/>
        /// Default Value: false
        /// </param>
        /// <param name="needLayoutVisualization">
        /// Whether to return detailed layout image result information<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startPageId">
        /// Start page number for parsing when PDF is provided
        /// </param>
        /// <param name="endPageId">
        /// End page number for parsing when PDF is provided
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
        public async global::System.Threading.Tasks.Task<global::ZAI.LayoutParsingResponse> CreatePaasV4LayoutParsingAsync(
            string file,
            global::ZAI.LayoutParsingRequestModel model = default,
            bool? returnCropImages = default,
            bool? needLayoutVisualization = default,
            int? startPageId = default,
            int? endPageId = default,
            string? requestId = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ZAI.LayoutParsingRequest
            {
                Model = model,
                File = file,
                ReturnCropImages = returnCropImages,
                NeedLayoutVisualization = needLayoutVisualization,
                StartPageId = startPageId,
                EndPageId = endPageId,
                RequestId = requestId,
                UserId = userId,
            };

            return await CreatePaasV4LayoutParsingAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}