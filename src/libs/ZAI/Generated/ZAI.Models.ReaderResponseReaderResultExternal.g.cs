
#nullable enable

namespace ZAI
{
    /// <summary>
    /// External resources referenced by the page
    /// </summary>
    public sealed partial class ReaderResponseReaderResultExternal
    {
        /// <summary>
        /// Collection of external stylesheets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stylesheet")]
        public global::System.Collections.Generic.Dictionary<string, global::ZAI.ReaderResponseReaderResultExternalStylesheet2>? Stylesheet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponseReaderResultExternal" /> class.
        /// </summary>
        /// <param name="stylesheet">
        /// Collection of external stylesheets
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReaderResponseReaderResultExternal(
            global::System.Collections.Generic.Dictionary<string, global::ZAI.ReaderResponseReaderResultExternalStylesheet2>? stylesheet)
        {
            this.Stylesheet = stylesheet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponseReaderResultExternal" /> class.
        /// </summary>
        public ReaderResponseReaderResultExternal()
        {
        }
    }
}