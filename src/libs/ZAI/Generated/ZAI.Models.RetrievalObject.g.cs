
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrievalObject
    {
        /// <summary>
        /// Knowledge base ID, created or obtained from the platform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KnowledgeId { get; set; }

        /// <summary>
        /// Prompt template for requesting the model, a custom request template containing placeholders `{{ knowledge }}` and `{{ question }}`. Default template: Search for the answer to the question `{{question}}` in the document `{{ knowledge }}`. If an answer is found, respond only using statements from the document; if no answer is found, use your own knowledge to answer and inform the user that the information is not from the document. Do not repeat the question, start the answer directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalObject" /> class.
        /// </summary>
        /// <param name="knowledgeId">
        /// Knowledge base ID, created or obtained from the platform
        /// </param>
        /// <param name="promptTemplate">
        /// Prompt template for requesting the model, a custom request template containing placeholders `{{ knowledge }}` and `{{ question }}`. Default template: Search for the answer to the question `{{question}}` in the document `{{ knowledge }}`. If an answer is found, respond only using statements from the document; if no answer is found, use your own knowledge to answer and inform the user that the information is not from the document. Do not repeat the question, start the answer directly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievalObject(
            string knowledgeId,
            string? promptTemplate)
        {
            this.KnowledgeId = knowledgeId ?? throw new global::System.ArgumentNullException(nameof(knowledgeId));
            this.PromptTemplate = promptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalObject" /> class.
        /// </summary>
        public RetrievalObject()
        {
        }

    }
}