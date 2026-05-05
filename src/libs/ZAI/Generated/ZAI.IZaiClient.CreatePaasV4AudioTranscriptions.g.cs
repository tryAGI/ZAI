#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// Speech to Text<br/>
        /// Use the [GLM-ASR-2512](/guides/audio/glm-asr-2512) model to transcribe audio files into text, supporting multiple languages and real-time streaming transcription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AudioTranscriptionResponse> CreatePaasV4AudioTranscriptionsAsync(

            global::ZAI.AudioTranscriptionRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech to Text<br/>
        /// Use the [GLM-ASR-2512](/guides/audio/glm-asr-2512) model to transcribe audio files into text, supporting multiple languages and real-time streaming transcription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.AudioTranscriptionResponse>> CreatePaasV4AudioTranscriptionsAsResponseAsync(

            global::ZAI.AudioTranscriptionRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech to Text<br/>
        /// Use the [GLM-ASR-2512](/guides/audio/glm-asr-2512) model to transcribe audio files into text, supporting multiple languages and real-time streaming transcription.
        /// </summary>
        /// <param name="file">
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </param>
        /// <param name="filename">
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </param>
        /// <param name="fileBase64">
        /// Base64 encoded audio file. Only one of file_base64 or file needs to be provided (if both are provided, file takes precedence).
        /// </param>
        /// <param name="model">
        /// The model ID to invoke.<br/>
        /// Default Value: glm-asr-2512
        /// </param>
        /// <param name="prompt">
        /// In long text scenarios, you can provide previous transcription results as context. Recommended to be less than 8000 characters.
        /// </param>
        /// <param name="hotwords">
        /// Hotword list to improve recognition accuracy for domain-specific vocabulary. Format example: ["person_name","place_name"]. Recommended not to exceed 100 items.
        /// </param>
        /// <param name="requestId">
        /// Passed by the client, must be unique. A unique identifier to distinguish each request. If not provided by the client, the platform will generate one by default.
        /// </param>
        /// <param name="userId">
        /// A unique `ID` for the end user, helping the platform intervene in illegal activities, generation of illegal or inappropriate content, or other abusive behaviors by end users. `ID` length requirement: at least `6` characters, at most `128` characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AudioTranscriptionResponse> CreatePaasV4AudioTranscriptionsAsync(
            byte[] file,
            string filename,
            string? fileBase64 = default,
            global::ZAI.AudioTranscriptionRequestModel model = global::ZAI.AudioTranscriptionRequestModel.GlmAsr2512,
            string? prompt = default,
            global::System.Collections.Generic.IList<string>? hotwords = default,
            string? requestId = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Speech to Text<br/>
        /// Use the [GLM-ASR-2512](/guides/audio/glm-asr-2512) model to transcribe audio files into text, supporting multiple languages and real-time streaming transcription.
        /// </summary>
        /// <param name="file">
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </param>
        /// <param name="filename">
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </param>
        /// <param name="fileBase64">
        /// Base64 encoded audio file. Only one of file_base64 or file needs to be provided (if both are provided, file takes precedence).
        /// </param>
        /// <param name="model">
        /// The model ID to invoke.<br/>
        /// Default Value: glm-asr-2512
        /// </param>
        /// <param name="prompt">
        /// In long text scenarios, you can provide previous transcription results as context. Recommended to be less than 8000 characters.
        /// </param>
        /// <param name="hotwords">
        /// Hotword list to improve recognition accuracy for domain-specific vocabulary. Format example: ["person_name","place_name"]. Recommended not to exceed 100 items.
        /// </param>
        /// <param name="requestId">
        /// Passed by the client, must be unique. A unique identifier to distinguish each request. If not provided by the client, the platform will generate one by default.
        /// </param>
        /// <param name="userId">
        /// A unique `ID` for the end user, helping the platform intervene in illegal activities, generation of illegal or inappropriate content, or other abusive behaviors by end users. `ID` length requirement: at least `6` characters, at most `128` characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AudioTranscriptionResponse> CreatePaasV4AudioTranscriptionsAsync(
            global::System.IO.Stream file,
            string filename,
            string? fileBase64 = default,
            global::ZAI.AudioTranscriptionRequestModel model = global::ZAI.AudioTranscriptionRequestModel.GlmAsr2512,
            string? prompt = default,
            global::System.Collections.Generic.IList<string>? hotwords = default,
            string? requestId = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech to Text<br/>
        /// Use the [GLM-ASR-2512](/guides/audio/glm-asr-2512) model to transcribe audio files into text, supporting multiple languages and real-time streaming transcription.
        /// </summary>
        /// <param name="file">
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </param>
        /// <param name="filename">
        /// The audio file to be transcribed. Supported audio file formats: `.wav / .mp3`. Specifications: file size ≤ `25 MB`, audio duration ≤ `30 seconds`.
        /// </param>
        /// <param name="fileBase64">
        /// Base64 encoded audio file. Only one of file_base64 or file needs to be provided (if both are provided, file takes precedence).
        /// </param>
        /// <param name="model">
        /// The model ID to invoke.<br/>
        /// Default Value: glm-asr-2512
        /// </param>
        /// <param name="prompt">
        /// In long text scenarios, you can provide previous transcription results as context. Recommended to be less than 8000 characters.
        /// </param>
        /// <param name="hotwords">
        /// Hotword list to improve recognition accuracy for domain-specific vocabulary. Format example: ["person_name","place_name"]. Recommended not to exceed 100 items.
        /// </param>
        /// <param name="requestId">
        /// Passed by the client, must be unique. A unique identifier to distinguish each request. If not provided by the client, the platform will generate one by default.
        /// </param>
        /// <param name="userId">
        /// A unique `ID` for the end user, helping the platform intervene in illegal activities, generation of illegal or inappropriate content, or other abusive behaviors by end users. `ID` length requirement: at least `6` characters, at most `128` characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.AudioTranscriptionResponse>> CreatePaasV4AudioTranscriptionsAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? fileBase64 = default,
            global::ZAI.AudioTranscriptionRequestModel model = global::ZAI.AudioTranscriptionRequestModel.GlmAsr2512,
            string? prompt = default,
            global::System.Collections.Generic.IList<string>? hotwords = default,
            string? requestId = default,
            string? userId = default,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}