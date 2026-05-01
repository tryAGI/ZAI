
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpecialEffectsVideosAgentResponseVariant1
    {
        /// <summary>
        /// Asynchronous task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_id")]
        public string? AsyncId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentResponseVariant1" /> class.
        /// </summary>
        /// <param name="asyncId">
        /// Asynchronous task ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpecialEffectsVideosAgentResponseVariant1(
            string? asyncId)
        {
            this.AsyncId = asyncId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialEffectsVideosAgentResponseVariant1" /> class.
        /// </summary>
        public SpecialEffectsVideosAgentResponseVariant1()
        {
        }
    }
}