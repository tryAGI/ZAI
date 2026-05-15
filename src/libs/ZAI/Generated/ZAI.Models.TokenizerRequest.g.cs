
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizerRequest
    {
        /// <summary>
        /// The model code to be called.<br/>
        /// Default Value: glm-4.6<br/>
        /// Example: glm-4.6
        /// </summary>
        /// <default>global::ZAI.TokenizerRequestModel.Glm46</default>
        /// <example>glm-4.6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TokenizerRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.TokenizerRequestModel Model { get; set; } = global::ZAI.TokenizerRequestModel.Glm46;

        /// <summary>
        /// The current conversation message list as the model’s prompt input, provided in JSON array format, e.g.,`{“role”: “user”, “content”: “Hello”}`. Possible message types include system messages, user messages. Note: The input must not consist of system or assistant messages only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.TokenizerRequestMessageUserMessage, global::ZAI.TokenizerRequestMessageSystemMessage, global::ZAI.TokenizerRequestMessageAssistantMessage>> Messages { get; set; }

        /// <summary>
        /// List of tools the model can call. Supports up to `128` functions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::ZAI.FunctionToolSchema>? Tools { get; set; }

        /// <summary>
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Unique ID for the end user, 6–128 characters. Avoid using sensitive information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model code to be called.<br/>
        /// Default Value: glm-4.6<br/>
        /// Example: glm-4.6
        /// </param>
        /// <param name="messages">
        /// The current conversation message list as the model’s prompt input, provided in JSON array format, e.g.,`{“role”: “user”, “content”: “Hello”}`. Possible message types include system messages, user messages. Note: The input must not consist of system or assistant messages only.
        /// </param>
        /// <param name="tools">
        /// List of tools the model can call. Supports up to `128` functions.
        /// </param>
        /// <param name="requestId">
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </param>
        /// <param name="userId">
        /// Unique ID for the end user, 6–128 characters. Avoid using sensitive information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizerRequest(
            global::ZAI.TokenizerRequestModel model,
            global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.TokenizerRequestMessageUserMessage, global::ZAI.TokenizerRequestMessageSystemMessage, global::ZAI.TokenizerRequestMessageAssistantMessage>> messages,
            global::System.Collections.Generic.IList<global::ZAI.FunctionToolSchema>? tools,
            string? requestId,
            string? userId)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Tools = tools;
            this.RequestId = requestId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerRequest" /> class.
        /// </summary>
        public TokenizerRequest()
        {
        }

    }
}