
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Document basic information
    /// </summary>
    public sealed partial class DataInfo
    {
        /// <summary>
        /// Total number of document pages<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumPages { get; set; }

        /// <summary>
        /// Document page count information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<global::ZAI.PageInfo>? Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataInfo" /> class.
        /// </summary>
        /// <param name="numPages">
        /// Total number of document pages<br/>
        /// Example: 5
        /// </param>
        /// <param name="pages">
        /// Document page count information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataInfo(
            int numPages,
            global::System.Collections.Generic.IList<global::ZAI.PageInfo>? pages)
        {
            this.NumPages = numPages;
            this.Pages = pages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataInfo" /> class.
        /// </summary>
        public DataInfo()
        {
        }

    }
}