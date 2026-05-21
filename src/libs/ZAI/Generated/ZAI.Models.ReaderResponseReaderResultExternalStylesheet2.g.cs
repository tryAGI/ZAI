
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReaderResponseReaderResultExternalStylesheet2
    {
        /// <summary>
        /// Stylesheet MIME type, typically `text/css`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponseReaderResultExternalStylesheet2" /> class.
        /// </summary>
        /// <param name="type">
        /// Stylesheet MIME type, typically `text/css`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReaderResponseReaderResultExternalStylesheet2(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResponseReaderResultExternalStylesheet2" /> class.
        /// </summary>
        public ReaderResponseReaderResultExternalStylesheet2()
        {
        }

    }
}