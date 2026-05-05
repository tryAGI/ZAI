#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// Generate Image (Async)<br/>
        /// Use the [GLM-Image](/guides/image/glm-image) series models to generate high-quality images from text prompts. Through quick and accurate understanding of user text descriptions, `AI` image expression becomes more precise and personalized. Only supports `GLM-Image` model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AsyncResponse> CreatePaasV4AsyncImagesGenerationsAsync(

            global::ZAI.AsyncCreateImageRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Image (Async)<br/>
        /// Use the [GLM-Image](/guides/image/glm-image) series models to generate high-quality images from text prompts. Through quick and accurate understanding of user text descriptions, `AI` image expression becomes more precise and personalized. Only supports `GLM-Image` model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.AsyncResponse>> CreatePaasV4AsyncImagesGenerationsAsResponseAsync(

            global::ZAI.AsyncCreateImageRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::ZAI.AsyncResponse> CreatePaasV4AsyncImagesGenerationsAsync(
            string prompt,
            global::ZAI.AsyncCreateImageRequestModel model = default,
            global::ZAI.AsyncCreateImageRequestQuality? quality = default,
            string? size = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}