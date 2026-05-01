
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePaasV4FilesRequest
    {
        /// <summary>
        /// Upload purpose (agent)<br/>
        /// Default Value: agent
        /// </summary>
        /// <default>global::ZAI.CreatePaasV4FilesRequestPurpose.Agent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.CreatePaasV4FilesRequestPurposeJsonConverter))]
        public global::ZAI.CreatePaasV4FilesRequestPurpose Purpose { get; set; } = global::ZAI.CreatePaasV4FilesRequestPurpose.Agent;

        /// <summary>
        /// File to upload. Limit to `100MB`. Allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// File to upload. Limit to `100MB`. Allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`.
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
        /// <param name="file">
        /// File to upload. Limit to `100MB`. Allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`.
        /// </param>
        /// <param name="filename">
        /// File to upload. Limit to `100MB`. Allowed formats: `pdf`, `doc`, `xlsx`, `ppt`, `txt`, `jpg`, `png`.
        /// </param>
        /// <param name="purpose">
        /// Upload purpose (agent)<br/>
        /// Default Value: agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePaasV4FilesRequest(
            byte[] file,
            string filename,
            global::ZAI.CreatePaasV4FilesRequestPurpose purpose = global::ZAI.CreatePaasV4FilesRequestPurpose.Agent)
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