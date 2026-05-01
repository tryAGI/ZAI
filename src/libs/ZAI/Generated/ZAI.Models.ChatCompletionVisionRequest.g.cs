
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionVisionRequest
    {
        /// <summary>
        /// The model code to be called. GLM-5V-Turbo are the new generation of visual reasoning models. `AutoGLM-Phone-Multilingual` is mobile intelligent assistant model.<br/>
        /// Default Value: glm-5v-turbo<br/>
        /// Example: glm-5v-turbo
        /// </summary>
        /// <default>global::ZAI.ChatCompletionVisionRequestModel.Glm5vTurbo</default>
        /// <example>glm-5v-turbo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.ChatCompletionVisionRequestModel Model { get; set; } = global::ZAI.ChatCompletionVisionRequestModel.Glm5vTurbo;

        /// <summary>
        /// The current conversation message list as the model’s prompt input, provided in JSON array format, e.g.,`{“role”: “user”, “content”: “Hello”}`. Possible message types include system messages, user messages. Note: The input must not consist of system or assistant messages only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.ChatCompletionVisionRequestMessageUserMessage, global::ZAI.ChatCompletionVisionRequestMessageSystemMessage, global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage>> Messages { get; set; }

        /// <summary>
        /// Passed by the user side, needs to be unique; used to distinguish each request. If not provided by the user side, the platform will generate one by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

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
        /// Sampling temperature, controls the randomness of the output, must be a positive number within the range: `[0.0, 1.0]`. The GLM-5V-Turbo, GLM-4.6V, GLM-4.5V series default value is `0.8`, the autoglm-phone-multilingual default value is `0.0`.<br/>
        /// Default Value: 0.8F<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Another method of temperature sampling, value range is: `[0.01, 1.0]`, value range is: `[0.01, 1.0]`. The GLM-5V-Turbo, GLM-4.6V, GLM-4.5V series default value is `0.6`, the autoglm-phone-multilingual default value is `0.85`.<br/>
        /// Default Value: 0.6F<br/>
        /// Example: 0.6F
        /// </summary>
        /// <example>0.6F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// The maximum number of tokens for model output, the GLM-5V-Turbo supports 128K maximum output, GLM-4.6V series supports 32K maximum output, the GLM-4.5V series supports 16K maximum output, the autoglm-phone-multilingual supports 4K maximum output.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A list of tools the model may call. Only support by GLM-4.6V series and autoglm-phone-multilingual. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::ZAI.FunctionToolSchema>? Tools { get; set; }

        /// <summary>
        /// Controls how the model selects a tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestToolChoiceJsonConverter))]
        public global::ZAI.ChatCompletionVisionRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Stop word list. Generation stops when the model encounters any specified string. Currently, only one stop word is supported, in the format ["stop_word1"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCompletionVisionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model code to be called. GLM-5V-Turbo are the new generation of visual reasoning models. `AutoGLM-Phone-Multilingual` is mobile intelligent assistant model.<br/>
        /// Default Value: glm-5v-turbo<br/>
        /// Example: glm-5v-turbo
        /// </param>
        /// <param name="messages">
        /// The current conversation message list as the model’s prompt input, provided in JSON array format, e.g.,`{“role”: “user”, “content”: “Hello”}`. Possible message types include system messages, user messages. Note: The input must not consist of system or assistant messages only.
        /// </param>
        /// <param name="requestId">
        /// Passed by the user side, needs to be unique; used to distinguish each request. If not provided by the user side, the platform will generate one by default.
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
        /// <param name="temperature">
        /// Sampling temperature, controls the randomness of the output, must be a positive number within the range: `[0.0, 1.0]`. The GLM-5V-Turbo, GLM-4.6V, GLM-4.5V series default value is `0.8`, the autoglm-phone-multilingual default value is `0.0`.<br/>
        /// Default Value: 0.8F<br/>
        /// Example: 0.8F
        /// </param>
        /// <param name="topP">
        /// Another method of temperature sampling, value range is: `[0.01, 1.0]`, value range is: `[0.01, 1.0]`. The GLM-5V-Turbo, GLM-4.6V, GLM-4.5V series default value is `0.6`, the autoglm-phone-multilingual default value is `0.85`.<br/>
        /// Default Value: 0.6F<br/>
        /// Example: 0.6F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens for model output, the GLM-5V-Turbo supports 128K maximum output, GLM-4.6V series supports 32K maximum output, the GLM-4.5V series supports 16K maximum output, the autoglm-phone-multilingual supports 4K maximum output.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Only support by GLM-4.6V series and autoglm-phone-multilingual. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        /// <param name="toolChoice">
        /// Controls how the model selects a tool.
        /// </param>
        /// <param name="stop">
        /// Stop word list. Generation stops when the model encounters any specified string. Currently, only one stop word is supported, in the format ["stop_word1"].
        /// </param>
        /// <param name="userId">
        /// Unique ID for the end user, 6–128 characters. Avoid using sensitive information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionVisionRequest(
            global::ZAI.ChatCompletionVisionRequestModel model,
            global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.ChatCompletionVisionRequestMessageUserMessage, global::ZAI.ChatCompletionVisionRequestMessageSystemMessage, global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage>> messages,
            string? requestId,
            bool? doSample,
            bool? stream,
            global::ZAI.ChatThinking? thinking,
            float? temperature,
            float? topP,
            int? maxTokens,
            global::System.Collections.Generic.IList<global::ZAI.FunctionToolSchema>? tools,
            global::ZAI.ChatCompletionVisionRequestToolChoice? toolChoice,
            global::System.Collections.Generic.IList<string>? stop,
            string? userId)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.RequestId = requestId;
            this.DoSample = doSample;
            this.Stream = stream;
            this.Thinking = thinking;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Stop = stop;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionVisionRequest" /> class.
        /// </summary>
        public ChatCompletionVisionRequest()
        {
        }
    }
}