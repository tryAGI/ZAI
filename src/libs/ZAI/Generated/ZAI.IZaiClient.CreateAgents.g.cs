#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// General Translation: General Translation API provides large model-based multilingual translation services, including general translation, paraphrase translation, two-step translation, and three-pass translation strategies. It supports automatic language detection, glossary customization, translation suggestions, and streaming output. Users only need to call the Translation API, input the text to be processed, specify the source language (auto-detection supported) and target language to receive high-quality translation results. <br/>
        ///  Popular Special Effects Videos: Popular special effects videos are intelligent templates launched based on trending features from pan-entertainment platforms, designed to precisely adapt to short video creative production needs. Currently, three effect templates are available: `French Kiss`, `Body Shake Dance`, and `Sexy Me`. After selecting a template, users only need to upload an image and enter corresponding prompts to generate a special effects video. <br/>
        ///  GLM Slide/Poster Agent: An intelligent creation agent built for working people and creators. It goes beyond traditional engineering-style assembly tools—supporting one-click generation of slides or posters from natural language instructions. By natively integrating content generation with layout aesthetics and design conventions, it helps you quickly produce polished, professional-grade materials while lowering design barriers and boosting creative efficiency.
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
        global::System.Threading.Tasks.Task<global::ZAI.OneOf<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>> CreateAgentsAsync(

            global::ZAI.OneOf<global::ZAI.TranslationAgentRequest, global::ZAI.SpecialEffectsVideosAgentRequest, global::ZAI.GlmSlideAgentRequest> request,
            global::ZAI.CreateAgentsAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// General Translation: General Translation API provides large model-based multilingual translation services, including general translation, paraphrase translation, two-step translation, and three-pass translation strategies. It supports automatic language detection, glossary customization, translation suggestions, and streaming output. Users only need to call the Translation API, input the text to be processed, specify the source language (auto-detection supported) and target language to receive high-quality translation results. <br/>
        ///  Popular Special Effects Videos: Popular special effects videos are intelligent templates launched based on trending features from pan-entertainment platforms, designed to precisely adapt to short video creative production needs. Currently, three effect templates are available: `French Kiss`, `Body Shake Dance`, and `Sexy Me`. After selecting a template, users only need to upload an image and enter corresponding prompts to generate a special effects video. <br/>
        ///  GLM Slide/Poster Agent: An intelligent creation agent built for working people and creators. It goes beyond traditional engineering-style assembly tools—supporting one-click generation of slides or posters from natural language instructions. By natively integrating content generation with layout aesthetics and design conventions, it helps you quickly produce polished, professional-grade materials while lowering design barriers and boosting creative efficiency.
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
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.OneOf<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>>> CreateAgentsAsResponseAsync(

            global::ZAI.OneOf<global::ZAI.TranslationAgentRequest, global::ZAI.SpecialEffectsVideosAgentRequest, global::ZAI.GlmSlideAgentRequest> request,
            global::ZAI.CreateAgentsAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// General Translation: General Translation API provides large model-based multilingual translation services, including general translation, paraphrase translation, two-step translation, and three-pass translation strategies. It supports automatic language detection, glossary customization, translation suggestions, and streaming output. Users only need to call the Translation API, input the text to be processed, specify the source language (auto-detection supported) and target language to receive high-quality translation results. <br/>
        ///  Popular Special Effects Videos: Popular special effects videos are intelligent templates launched based on trending features from pan-entertainment platforms, designed to precisely adapt to short video creative production needs. Currently, three effect templates are available: `French Kiss`, `Body Shake Dance`, and `Sexy Me`. After selecting a template, users only need to upload an image and enter corresponding prompts to generate a special effects video. <br/>
        ///  GLM Slide/Poster Agent: An intelligent creation agent built for working people and creators. It goes beyond traditional engineering-style assembly tools—supporting one-click generation of slides or posters from natural language instructions. By natively integrating content generation with layout aesthetics and design conventions, it helps you quickly produce polished, professional-grade materials while lowering design barriers and boosting creative efficiency.
        /// </summary>
        /// <param name="acceptLanguage">
        /// Config desired response language for HTTP requests.<br/>
        /// Default Value: en-US,en<br/>
        /// Example: en-US,en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.OneOf<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>> CreateAgentsAsync(
            global::ZAI.CreateAgentsAcceptLanguage? acceptLanguage = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}