
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrievalToolSchema
    {
        /// <summary>
        /// Default Value: retrieval
        /// </summary>
        /// <default>global::ZAI.RetrievalToolSchemaType.Retrieval</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.RetrievalToolSchemaTypeJsonConverter))]
        public global::ZAI.RetrievalToolSchemaType Type { get; set; } = global::ZAI.RetrievalToolSchemaType.Retrieval;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.RetrievalObject Retrieval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalToolSchema" /> class.
        /// </summary>
        /// <param name="retrieval"></param>
        /// <param name="type">
        /// Default Value: retrieval
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievalToolSchema(
            global::ZAI.RetrievalObject retrieval,
            global::ZAI.RetrievalToolSchemaType type = global::ZAI.RetrievalToolSchemaType.Retrieval)
        {
            this.Type = type;
            this.Retrieval = retrieval ?? throw new global::System.ArgumentNullException(nameof(retrieval));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalToolSchema" /> class.
        /// </summary>
        public RetrievalToolSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RetrievalToolSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RetrievalToolSchema FromRetrieval(global::ZAI.RetrievalObject retrieval)
        {
            return new RetrievalToolSchema
            {
                Retrieval = retrieval,
            };
        }

    }
}