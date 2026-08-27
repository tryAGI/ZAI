
#nullable enable

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayoutParsingResponse
    {
        /// <summary>
        /// Task ID<br/>
        /// Example: task_123456789
        /// </summary>
        /// <example>task_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Request creation time, Unix timestamp in seconds<br/>
        /// Example: 1727156815
        /// </summary>
        /// <example>1727156815</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Model name<br/>
        /// Example: GLM-OCR
        /// </summary>
        /// <example>GLM-OCR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Recognition result in Markdown format<br/>
        /// Example: # Doc title<br/>
        /// This is the document content...
        /// </summary>
        /// <example>
        /// # Doc title<br/>
        /// This is the document content...
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("md_results")]
        public string? MdResults { get; set; }

        /// <summary>
        /// Detailed layout information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_details")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>>? LayoutDetails { get; set; }

        /// <summary>
        /// Recognition result image URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_visualization")]
        public global::System.Collections.Generic.IList<string>? LayoutVisualization { get; set; }

        /// <summary>
        /// Document basic information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_info")]
        public global::ZAI.DataInfo? DataInfo { get; set; }

        /// <summary>
        /// Token usage statistics returned when the model call ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::ZAI.LayoutParsingResponseUsage? Usage { get; set; }

        /// <summary>
        /// Request ID<br/>
        /// Example: req_123456789
        /// </summary>
        /// <example>req_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutParsingResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task ID<br/>
        /// Example: task_123456789
        /// </param>
        /// <param name="created">
        /// Request creation time, Unix timestamp in seconds<br/>
        /// Example: 1727156815
        /// </param>
        /// <param name="model">
        /// Model name<br/>
        /// Example: GLM-OCR
        /// </param>
        /// <param name="mdResults">
        /// Recognition result in Markdown format<br/>
        /// Example: # Doc title<br/>
        /// This is the document content...
        /// </param>
        /// <param name="layoutDetails">
        /// Detailed layout information
        /// </param>
        /// <param name="layoutVisualization">
        /// Recognition result image URLs
        /// </param>
        /// <param name="dataInfo">
        /// Document basic information
        /// </param>
        /// <param name="usage">
        /// Token usage statistics returned when the model call ends.
        /// </param>
        /// <param name="requestId">
        /// Request ID<br/>
        /// Example: req_123456789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutParsingResponse(
            string id,
            global::System.DateTimeOffset created,
            string model,
            string? mdResults,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>>? layoutDetails,
            global::System.Collections.Generic.IList<string>? layoutVisualization,
            global::ZAI.DataInfo? dataInfo,
            global::ZAI.LayoutParsingResponseUsage? usage,
            string? requestId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MdResults = mdResults;
            this.LayoutDetails = layoutDetails;
            this.LayoutVisualization = layoutVisualization;
            this.DataInfo = dataInfo;
            this.Usage = usage;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutParsingResponse" /> class.
        /// </summary>
        public LayoutParsingResponse()
        {
        }

    }
}