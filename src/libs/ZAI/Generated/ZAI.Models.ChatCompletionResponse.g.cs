
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponse
    {
        /// <summary>
        /// Task ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Request ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Request creation time, Unix timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// List of model responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseChoice>? Choices { get; set; }

        /// <summary>
        /// Token usage statistics returned when the model call ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::ZAI.ChatCompletionResponseUsage? Usage { get; set; }

        /// <summary>
        /// Search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>? WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task ID
        /// </param>
        /// <param name="requestId">
        /// Request ID
        /// </param>
        /// <param name="created">
        /// Request creation time, Unix timestamp in seconds
        /// </param>
        /// <param name="model">
        /// Model name
        /// </param>
        /// <param name="choices">
        /// List of model responses
        /// </param>
        /// <param name="usage">
        /// Token usage statistics returned when the model call ends.
        /// </param>
        /// <param name="webSearch">
        /// Search results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponse(
            string? id,
            string? requestId,
            global::System.DateTimeOffset? created,
            string? model,
            global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseChoice>? choices,
            global::ZAI.ChatCompletionResponseUsage? usage,
            global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>? webSearch)
        {
            this.Id = id;
            this.RequestId = requestId;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
            this.WebSearch = webSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        public ChatCompletionResponse()
        {
        }

    }
}