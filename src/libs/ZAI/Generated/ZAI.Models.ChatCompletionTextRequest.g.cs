
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionTextRequest
    {
        /// <summary>
        /// The model code to be called. GLM-5.3, GLM-5.2, GLM-5.1, GLM-5-Turbo are the latest flagship model series, foundational models specifically designed for agent applications.<br/>
        /// Default Value: glm-5.3<br/>
        /// Example: glm-5.3
        /// </summary>
        /// <default>global::ZAI.ChatCompletionTextRequestModel.Glm53</default>
        /// <example>glm-5.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.ChatCompletionTextRequestModel Model { get; set; } = global::ZAI.ChatCompletionTextRequestModel.Glm53;

        /// <summary>
        /// The current conversation message list as the model’s prompt input, provided in JSON array format, e.g.,`{“role”: “user”, “content”: “Hello”}`. Possible message types include system messages, user messages, assistant messages, and tool messages. Note: The input must not consist of system messages or assistant messages only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequestMessageUserMessage, global::ZAI.ChatCompletionTextRequestMessageSystemMessage, global::ZAI.ChatCompletionTextRequestMessageAssistantMessage, global::ZAI.ChatCompletionTextRequestMessageToolMessage>> Messages { get; set; }

        /// <summary>
        /// When do_sample is true, sampling strategy is enabled; when do_sample is false, sampling strategy parameters such as temperature and top_p will not take effect. Default value is `true`.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_sample")]
        public bool? DoSample { get; set; }

        /// <summary>
        /// This parameter should be set to false or omitted when using synchronous call. It indicates that the model returns all content at once after generating all content. Default value is false. If set to true, the model will return the generated content in chunks via standard Event Stream. When the Event Stream ends, a `data: [DONE]` message will be returned.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Only supported by GLM-4.5 series and higher models. This parameter is used to control whether the model enable the chain of thought.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::ZAI.ChatThinking? Thinking { get; set; }

        /// <summary>
        /// Controls the model's reasoning effort level, takes effect when `thinking` is enabled. Default is `max`, supported by `GLM-5.2` and above. For the `GLM-5.3` `GLM-5.3-FLASH` model, only the `low` / `high` / `max` levels are supported. For the `GLM-5.2` model, for compatibility with other protocols, passing `none` or `minimal` will cause the model to skip thinking; `low` and `medium` will be mapped to `high`; `xhigh` will be mapped to `max`.<br/>
        /// Default Value: max<br/>
        /// Example: max
        /// </summary>
        /// <example>max</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestReasoningEffortJsonConverter))]
        public global::ZAI.ChatCompletionTextRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Sampling temperature, controls the randomness of the output, must be a positive number within the range: `[0.0, 1.0]`. The GLM-5.3, GLM-5.2, GLM-5.1, GLM-5, GLM-4.7, GLM-4.6 series default value is `1.0`, GLM-4.5 series default value is `0.6`, GLM-4-32B-0414-128K default value is `0.75`.<br/>
        /// Default Value: 1F<br/>
        /// Example: 1F
        /// </summary>
        /// <example>1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Another method of temperature sampling, value range is: `[0.01, 1.0]`. The GLM-5.3, GLM-5.2, GLM-5.1, GLM-5, GLM-4.7, GLM-4.6, GLM-4.5 series default value is `0.95`, GLM-4-32B-0414-128K default value is `0.9`.<br/>
        /// Default Value: 0.95F<br/>
        /// Example: 0.95F
        /// </summary>
        /// <example>0.95F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// The maximum number of tokens for model output, the GLM-5.3, GLM-5.2, GLM-5.1, GLM-5, GLM-4.7, GLM-4.6 series supports 128K maximum output, the GLM-4.5 series supports 96K maximum output, the GLM-4.6v series supports 32K maximum output, the GLM-4.5v series supports 16K maximum output, GLM-4-32B-0414-128K supports 16K maximum output.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Whether to enable streaming response for Function Calls. Default value is false. Only supported by the GLM-5.3, GLM-5.2, GLM-5.1, GLM-5, GLM-5-Turbo, GLM-4.7, and GLM-4.6 series. Refer to the [Stream Tool Call](/guides/tools/stream-tool)<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_stream")]
        public bool? ToolStream { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>>? Tools { get; set; }

        /// <summary>
        /// Controls how the model selects a tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestToolChoiceJsonConverter))]
        public global::ZAI.ChatCompletionTextRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Stop word list. Generation stops when the model encounters any specified string. Currently, only one stop word is supported, in the format ["stop_word1"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// Specifies the response format of the model. Defaults to text. Only text models support this field. `type` converges to three values: `text` (plain text output), `json_object` (JSON output).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::ZAI.ChatCompletionTextRequestResponseFormat? ResponseFormat { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model code to be called. GLM-5.3, GLM-5.2, GLM-5.1, GLM-5-Turbo are the latest flagship model series, foundational models specifically designed for agent applications.<br/>
        /// Default Value: glm-5.3<br/>
        /// Example: glm-5.3
        /// </param>
        /// <param name="messages">
        /// The current conversation message list as the model’s prompt input, provided in JSON array format, e.g.,`{“role”: “user”, “content”: “Hello”}`. Possible message types include system messages, user messages, assistant messages, and tool messages. Note: The input must not consist of system messages or assistant messages only.
        /// </param>
        /// <param name="doSample">
        /// When do_sample is true, sampling strategy is enabled; when do_sample is false, sampling strategy parameters such as temperature and top_p will not take effect. Default value is `true`.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="stream">
        /// This parameter should be set to false or omitted when using synchronous call. It indicates that the model returns all content at once after generating all content. Default value is false. If set to true, the model will return the generated content in chunks via standard Event Stream. When the Event Stream ends, a `data: [DONE]` message will be returned.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="thinking">
        /// Only supported by GLM-4.5 series and higher models. This parameter is used to control whether the model enable the chain of thought.
        /// </param>
        /// <param name="reasoningEffort">
        /// Controls the model's reasoning effort level, takes effect when `thinking` is enabled. Default is `max`, supported by `GLM-5.2` and above. For the `GLM-5.3` `GLM-5.3-FLASH` model, only the `low` / `high` / `max` levels are supported. For the `GLM-5.2` model, for compatibility with other protocols, passing `none` or `minimal` will cause the model to skip thinking; `low` and `medium` will be mapped to `high`; `xhigh` will be mapped to `max`.<br/>
        /// Default Value: max<br/>
        /// Example: max
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature, controls the randomness of the output, must be a positive number within the range: `[0.0, 1.0]`. The GLM-5.3, GLM-5.2, GLM-5.1, GLM-5, GLM-4.7, GLM-4.6 series default value is `1.0`, GLM-4.5 series default value is `0.6`, GLM-4-32B-0414-128K default value is `0.75`.<br/>
        /// Default Value: 1F<br/>
        /// Example: 1F
        /// </param>
        /// <param name="topP">
        /// Another method of temperature sampling, value range is: `[0.01, 1.0]`. The GLM-5.3, GLM-5.2, GLM-5.1, GLM-5, GLM-4.7, GLM-4.6, GLM-4.5 series default value is `0.95`, GLM-4-32B-0414-128K default value is `0.9`.<br/>
        /// Default Value: 0.95F<br/>
        /// Example: 0.95F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens for model output, the GLM-5.3, GLM-5.2, GLM-5.1, GLM-5, GLM-4.7, GLM-4.6 series supports 128K maximum output, the GLM-4.5 series supports 96K maximum output, the GLM-4.6v series supports 32K maximum output, the GLM-4.5v series supports 16K maximum output, GLM-4-32B-0414-128K supports 16K maximum output.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="toolStream">
        /// Whether to enable streaming response for Function Calls. Default value is false. Only supported by the GLM-5.3, GLM-5.2, GLM-5.1, GLM-5, GLM-5-Turbo, GLM-4.7, and GLM-4.6 series. Refer to the [Stream Tool Call](/guides/tools/stream-tool)<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        /// <param name="toolChoice">
        /// Controls how the model selects a tool.
        /// </param>
        /// <param name="stop">
        /// Stop word list. Generation stops when the model encounters any specified string. Currently, only one stop word is supported, in the format ["stop_word1"].
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the response format of the model. Defaults to text. Only text models support this field. `type` converges to three values: `text` (plain text output), `json_object` (JSON output).
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
        public ChatCompletionTextRequest(
            global::ZAI.ChatCompletionTextRequestModel model,
            global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequestMessageUserMessage, global::ZAI.ChatCompletionTextRequestMessageSystemMessage, global::ZAI.ChatCompletionTextRequestMessageAssistantMessage, global::ZAI.ChatCompletionTextRequestMessageToolMessage>> messages,
            bool? doSample,
            bool? stream,
            global::ZAI.ChatThinking? thinking,
            global::ZAI.ChatCompletionTextRequestReasoningEffort? reasoningEffort,
            float? temperature,
            float? topP,
            int? maxTokens,
            bool? toolStream,
            global::System.Collections.Generic.IList<global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>>? tools,
            global::ZAI.ChatCompletionTextRequestToolChoice? toolChoice,
            global::System.Collections.Generic.IList<string>? stop,
            global::ZAI.ChatCompletionTextRequestResponseFormat? responseFormat,
            string? requestId,
            string? userId)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.DoSample = doSample;
            this.Stream = stream;
            this.Thinking = thinking;
            this.ReasoningEffort = reasoningEffort;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.ToolStream = toolStream;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Stop = stop;
            this.ResponseFormat = responseFormat;
            this.RequestId = requestId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTextRequest" /> class.
        /// </summary>
        public ChatCompletionTextRequest()
        {
        }

    }
}