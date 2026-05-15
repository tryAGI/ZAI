
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoCommonRequest
    {
        /// <summary>
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Unique ID of the end-user, assists the platform in intervening in end-user violations, generating illegal or inappropriate information, or other abusive behaviors. ID length requirement: minimum `6` characters, maximum `128` characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCommonRequest" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </param>
        /// <param name="userId">
        /// Unique ID of the end-user, assists the platform in intervening in end-user violations, generating illegal or inappropriate information, or other abusive behaviors. ID length requirement: minimum `6` characters, maximum `128` characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoCommonRequest(
            string? requestId,
            string? userId)
        {
            this.RequestId = requestId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCommonRequest" /> class.
        /// </summary>
        public VideoCommonRequest()
        {
        }

    }
}