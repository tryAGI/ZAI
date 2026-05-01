#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// Layout Parsing<br/>
        /// Use the [GLM-OCR](/guides/vlm/glm-ocr) model to parse the layout of documents and images and extract text content. Support OCR recognition of images and PDF documents, returning detailed layout information and visualization results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.LayoutParsingResponse> CreatePaasV4LayoutParsingAsync(

            global::ZAI.LayoutParsingRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Layout Parsing<br/>
        /// Use the [GLM-OCR](/guides/vlm/glm-ocr) model to parse the layout of documents and images and extract text content. Support OCR recognition of images and PDF documents, returning detailed layout information and visualization results.
        /// </summary>
        /// <param name="model">
        /// Model code: `glm-ocr`<br/>
        /// Example: glm-ocr
        /// </param>
        /// <param name="file">
        /// Image or PDF document to be recognized, supports URL and base64. Supported image formats: PDF, JPG, PNG. Single image ≤10MB, PDF ≤50MB, maximum support 100 pages<br/>
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
        /// Unique request identifier, automatically generated if not provided<br/>
        /// Example: req_123456789
        /// </param>
        /// <param name="userId">
        /// End user ID for abuse monitoring. Length: 6-128 characters<br/>
        /// Example: user_123456
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.LayoutParsingResponse> CreatePaasV4LayoutParsingAsync(
            string file,
            global::ZAI.LayoutParsingRequestModel model = default,
            bool? returnCropImages = default,
            bool? needLayoutVisualization = default,
            int? startPageId = default,
            int? endPageId = default,
            string? requestId = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}