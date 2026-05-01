
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlmSlideAgentConversationRequestCustomVariablesPage
    {
        /// <summary>
        /// Slide Page Position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public double? Position { get; set; }

        /// <summary>
        /// Slide Width, unit: pt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Slide Height, unit: pt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationRequestCustomVariablesPage" /> class.
        /// </summary>
        /// <param name="position">
        /// Slide Page Position
        /// </param>
        /// <param name="width">
        /// Slide Width, unit: pt
        /// </param>
        /// <param name="height">
        /// Slide Height, unit: pt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentConversationRequestCustomVariablesPage(
            double? position,
            double? width,
            double? height)
        {
            this.Position = position;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationRequestCustomVariablesPage" /> class.
        /// </summary>
        public GlmSlideAgentConversationRequestCustomVariablesPage()
        {
        }
    }
}