#nullable enable

namespace ZAI
{
    public partial interface IZaiClient
    {
        /// <summary>
        /// This API is designed for uploading auxiliary files (such as glossaries, terminology lists) to support the translation service. It allows users to upload reference materials that can enhance translation accuracy and consistency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.CreatePaasV4FilesResponse> CreatePaasV4FilesAsync(

            global::ZAI.CreatePaasV4FilesRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// This API is designed for uploading auxiliary files (such as glossaries, terminology lists) to support the translation service. It allows users to upload reference materials that can enhance translation accuracy and consistency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.CreatePaasV4FilesResponse>> CreatePaasV4FilesAsResponseAsync(

            global::ZAI.CreatePaasV4FilesRequest request,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// This API is designed for uploading auxiliary files (such as glossaries, terminology lists) to support the translation service. It allows users to upload reference materials that can enhance translation accuracy and consistency.
        /// </summary>
        /// <param name="purpose">
        /// Upload purpose<br/>
        /// Default Value: user_data
        /// </param>
        /// <param name="file">
        /// File to upload. `agent` limit to `100MB`, `user_data` limit to `1T`. `agent` allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`, `user_data` allowed formats: `pptx`, `ppt`, `docx`, `doc`, `xlsx`, `xls`, `pdf`.
        /// </param>
        /// <param name="filename">
        /// File to upload. `agent` limit to `100MB`, `user_data` limit to `1T`. `agent` allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`, `user_data` allowed formats: `pptx`, `ppt`, `docx`, `doc`, `xlsx`, `xls`, `pdf`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.CreatePaasV4FilesResponse> CreatePaasV4FilesAsync(
            byte[] file,
            string filename,
            global::ZAI.CreatePaasV4FilesRequestPurpose purpose = global::ZAI.CreatePaasV4FilesRequestPurpose.UserData,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This API is designed for uploading auxiliary files (such as glossaries, terminology lists) to support the translation service. It allows users to upload reference materials that can enhance translation accuracy and consistency.
        /// </summary>
        /// <param name="purpose">
        /// Upload purpose<br/>
        /// Default Value: user_data
        /// </param>
        /// <param name="file">
        /// File to upload. `agent` limit to `100MB`, `user_data` limit to `1T`. `agent` allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`, `user_data` allowed formats: `pptx`, `ppt`, `docx`, `doc`, `xlsx`, `xls`, `pdf`.
        /// </param>
        /// <param name="filename">
        /// File to upload. `agent` limit to `100MB`, `user_data` limit to `1T`. `agent` allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`, `user_data` allowed formats: `pptx`, `ppt`, `docx`, `doc`, `xlsx`, `xls`, `pdf`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.CreatePaasV4FilesResponse> CreatePaasV4FilesAsync(
            global::System.IO.Stream file,
            string filename,
            global::ZAI.CreatePaasV4FilesRequestPurpose purpose = global::ZAI.CreatePaasV4FilesRequestPurpose.UserData,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// This API is designed for uploading auxiliary files (such as glossaries, terminology lists) to support the translation service. It allows users to upload reference materials that can enhance translation accuracy and consistency.
        /// </summary>
        /// <param name="purpose">
        /// Upload purpose<br/>
        /// Default Value: user_data
        /// </param>
        /// <param name="file">
        /// File to upload. `agent` limit to `100MB`, `user_data` limit to `1T`. `agent` allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`, `user_data` allowed formats: `pptx`, `ppt`, `docx`, `doc`, `xlsx`, `xls`, `pdf`.
        /// </param>
        /// <param name="filename">
        /// File to upload. `agent` limit to `100MB`, `user_data` limit to `1T`. `agent` allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`, `user_data` allowed formats: `pptx`, `ppt`, `docx`, `doc`, `xlsx`, `xls`, `pdf`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ZAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ZAI.AutoSDKHttpResponse<global::ZAI.CreatePaasV4FilesResponse>> CreatePaasV4FilesAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::ZAI.CreatePaasV4FilesRequestPurpose purpose = global::ZAI.CreatePaasV4FilesRequestPurpose.UserData,
            global::ZAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}