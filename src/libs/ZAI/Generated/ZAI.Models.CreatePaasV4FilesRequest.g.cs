
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePaasV4FilesRequest
    {
        /// <summary>
        /// Upload purpose<br/>
        /// Default Value: user_data
        /// </summary>
        /// <default>global::ZAI.CreatePaasV4FilesRequestPurpose.UserData</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.CreatePaasV4FilesRequestPurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.CreatePaasV4FilesRequestPurpose Purpose { get; set; } = global::ZAI.CreatePaasV4FilesRequestPurpose.UserData;

        /// <summary>
        /// File to upload. `agent` limit to `100MB`, `user_data` limit to `1T`. `agent` allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`, `user_data` allowed formats: `pptx`, `ppt`, `docx`, `doc`, `xlsx`, `xls`, `pdf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// File to upload. `agent` limit to `100MB`, `user_data` limit to `1T`. `agent` allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`, `user_data` allowed formats: `pptx`, `ppt`, `docx`, `doc`, `xlsx`, `xls`, `pdf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaasV4FilesRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePaasV4FilesRequest(
            global::ZAI.CreatePaasV4FilesRequestPurpose purpose,
            byte[] file,
            string filename)
        {
            this.Purpose = purpose;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaasV4FilesRequest" /> class.
        /// </summary>
        public CreatePaasV4FilesRequest()
        {
        }

    }
}