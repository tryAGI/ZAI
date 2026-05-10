
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Only supported by GLM-4.5 series and higher models. This parameter is used to control whether the model enable the chain of thought.
    /// </summary>
    public sealed partial class ChatThinking
    {
        /// <summary>
        /// Whether to enable the chain of thought(When enabled, GLM-5.1 GLM-5 GLM-5-Turbo GLM-5V-Turbo GLM-4.7 GLM-4.5V will think compulsorily, while GLM-4.6, GLM-4.6V, GLM-4.5 and others will automatically determine whether to think), default: enabled<br/>
        /// Default Value: enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.ChatThinkingTypeJsonConverter))]
        public global::ZAI.ChatThinkingType? Type { get; set; }

        /// <summary>
        /// Default value is True. Controls whether to clear `reasoning_content` from previous conversation turns. View more in [Thinking Mode](/guides/capabilities/thinking-mode). <br/>
        ///  - `true` (default): For this request, the system ignores/removes `reasoning_content` from prior turns, and only keeps non-reasoning context (e.g., user/assistant visible text, tool calls, and tool results). This is recommended for general chat or lightweight tasks to reduce context length and cost. <br/>
        ///  - `false`: Retains `reasoning_content` from prior turns and includes it in the context sent to the model. To enable Preserved Thinking, you must forward the full, unmodified, and correctly ordered historical `reasoning_content` in `messages`. Missing, truncated, rewritten, or reordered blocks may degrade performance or prevent the feature from taking effect. <br/>
        ///  - Notes: This parameter only affects cross-turn historical thinking blocks; it does not change whether the model generates/returns thinking in the current turn.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_thinking")]
        public bool? ClearThinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatThinking" /> class.
        /// </summary>
        /// <param name="type">
        /// Whether to enable the chain of thought(When enabled, GLM-5.1 GLM-5 GLM-5-Turbo GLM-5V-Turbo GLM-4.7 GLM-4.5V will think compulsorily, while GLM-4.6, GLM-4.6V, GLM-4.5 and others will automatically determine whether to think), default: enabled<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="clearThinking">
        /// Default value is True. Controls whether to clear `reasoning_content` from previous conversation turns. View more in [Thinking Mode](/guides/capabilities/thinking-mode). <br/>
        ///  - `true` (default): For this request, the system ignores/removes `reasoning_content` from prior turns, and only keeps non-reasoning context (e.g., user/assistant visible text, tool calls, and tool results). This is recommended for general chat or lightweight tasks to reduce context length and cost. <br/>
        ///  - `false`: Retains `reasoning_content` from prior turns and includes it in the context sent to the model. To enable Preserved Thinking, you must forward the full, unmodified, and correctly ordered historical `reasoning_content` in `messages`. Missing, truncated, rewritten, or reordered blocks may degrade performance or prevent the feature from taking effect. <br/>
        ///  - Notes: This parameter only affects cross-turn historical thinking blocks; it does not change whether the model generates/returns thinking in the current turn.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatThinking(
            global::ZAI.ChatThinkingType? type,
            bool? clearThinking)
        {
            this.Type = type;
            this.ClearThinking = clearThinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatThinking" /> class.
        /// </summary>
        public ChatThinking()
        {
        }

    }
}