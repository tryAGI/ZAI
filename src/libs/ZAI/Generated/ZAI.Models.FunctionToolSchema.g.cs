
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionToolSchema
    {
        /// <summary>
        /// Default Value: function
        /// </summary>
        /// <default>global::ZAI.FunctionToolSchemaType.Function</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.FunctionToolSchemaTypeJsonConverter))]
        public global::ZAI.FunctionToolSchemaType Type { get; set; } = global::ZAI.FunctionToolSchemaType.Function;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.FunctionObject Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionToolSchema" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type">
        /// Default Value: function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionToolSchema(
            global::ZAI.FunctionObject function,
            global::ZAI.FunctionToolSchemaType type = global::ZAI.FunctionToolSchemaType.Function)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionToolSchema" /> class.
        /// </summary>
        public FunctionToolSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="FunctionToolSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static FunctionToolSchema FromFunction(global::ZAI.FunctionObject function)
        {
            return new FunctionToolSchema
            {
                Function = function,
            };
        }

    }
}