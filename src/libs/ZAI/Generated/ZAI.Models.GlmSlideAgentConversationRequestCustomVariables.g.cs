
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Custom variables
    /// </summary>
    public sealed partial class GlmSlideAgentConversationRequestCustomVariables
    {
        /// <summary>
        /// Is export the pdf file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_pdf")]
        public bool? IncludePdf { get; set; }

        /// <summary>
        /// Slides Pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>? Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationRequestCustomVariables" /> class.
        /// </summary>
        /// <param name="includePdf">
        /// Is export the pdf file
        /// </param>
        /// <param name="pages">
        /// Slides Pages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentConversationRequestCustomVariables(
            bool? includePdf,
            global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>? pages)
        {
            this.IncludePdf = includePdf;
            this.Pages = pages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentConversationRequestCustomVariables" /> class.
        /// </summary>
        public GlmSlideAgentConversationRequestCustomVariables()
        {
        }

    }
}