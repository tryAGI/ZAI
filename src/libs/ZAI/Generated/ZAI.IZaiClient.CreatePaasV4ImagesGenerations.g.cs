#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// Generate Image<br/>
        /// Use [GLM-Image](/guides/image/glm-image) series models to generate high-quality images from text prompts. Through quick and accurate understanding of user text descriptions, `AI` image expression becomes more precise and personalized.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.ImageGenerationResponse> CreatePaasV4ImagesGenerationsAsync(

            global::ZAI.CreateImageRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Image<br/>
        /// Use [GLM-Image](/guides/image/glm-image) series models to generate high-quality images from text prompts. Through quick and accurate understanding of user text descriptions, `AI` image expression becomes more precise and personalized.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.ImageGenerationResponse>> CreatePaasV4ImagesGenerationsAsResponseAsync(

            global::ZAI.CreateImageRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Image<br/>
        /// Use [GLM-Image](/guides/image/glm-image) series models to generate high-quality images from text prompts. Through quick and accurate understanding of user text descriptions, `AI` image expression becomes more precise and personalized.
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
        /// The quality of the generated image. `glm-image` default is `hd`, others model is `standard`. `hd`: Generates a more detailed and rich image with higher overall consistency, but takes about `20` seconds. `standard`: Generates an image quickly, suitable for scenarios with higher requirements for generation speed, takes about `5-10` seconds.<br/>
        /// Default Value: hd
        /// </param>
        /// <param name="size">
        /// Image size. `glm-image` recommended enum values: `1280x1280` (default), `1568x1056`, `1056x1568`, `1472x1088`, `1088x1472`, `1728x960`, `960x1728`. Custom parameter: Both width and height must be between `1024px-2048px`, and must be divisible by `32`, and the maximum pixel count must not exceed `2^22px`. <br/>
        /// Others model recommended enum values: `1024x1024` (default), `768x1344`, `864x1152`, `1344x768`, `1152x864`, `1440x720`, `720x1440`. Custom parameter: Both width and height must be between `512px-2048px`, and must be divisible by `16`, and the maximum pixel count must not exceed `2^21px`.<br/>
        /// Default Value: 1280x1280<br/>
        /// Example: 1280x1280
        /// </param>
        /// <param name="userId">
        /// Unique ID of the end user, helping the platform intervene in illegal activities, inappropriate content generation, or other abuses. ID length: 6 to 128 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.ImageGenerationResponse> CreatePaasV4ImagesGenerationsAsync(
            global::ZAI.CreateImageRequestModel model,
            string prompt,
            global::ZAI.CreateImageRequestQuality? quality = default,
            string? size = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}