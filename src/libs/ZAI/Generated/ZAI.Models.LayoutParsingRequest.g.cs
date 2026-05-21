
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutParsingRequest
    {
        /// <summary>
        /// Model code: `glm-ocr`<br/>
        /// Example: glm-ocr
        /// </summary>
        /// <example>glm-ocr</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.LayoutParsingRequestModelJsonConverter))]
        public global::ZAI.LayoutParsingRequestModel Model { get; set; }

        /// <summary>
        /// Image or PDF document to be recognized, supports URL and base64. Supported image formats: PDF, JPG, PNG. Single image ≤10MB, PDF ≤50MB, maximum support 100 pages<br/>
        /// Example: https://cdn.bigmodel.cn/static/logo/introduction.png
        /// </summary>
        /// <example>https://cdn.bigmodel.cn/static/logo/introduction.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string File { get; set; }

        /// <summary>
        /// Whether to return screenshot information<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_crop_images")]
        public bool? ReturnCropImages { get; set; }

        /// <summary>
        /// Whether to return detailed layout image result information<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("need_layout_visualization")]
        public bool? NeedLayoutVisualization { get; set; }

        /// <summary>
        /// Start page number for parsing when PDF is provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_page_id")]
        public int? StartPageId { get; set; }

        /// <summary>
        /// End page number for parsing when PDF is provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_page_id")]
        public int? EndPageId { get; set; }

        /// <summary>
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Unique ID for the end user, 6–128 characters. Avoid using sensitive information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutParsingRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Image or PDF document to be recognized, supports URL and base64. Supported image formats: PDF, JPG, PNG. Single image ≤10MB, PDF ≤50MB, maximum support 100 pages<br/>
        /// Example: https://cdn.bigmodel.cn/static/logo/introduction.png
        /// </param>
        /// <param name="model">
        /// Model code: `glm-ocr`<br/>
        /// Example: glm-ocr
        /// </param>
        /// <param name="returnCropImages">
        /// Whether to return screenshot information<br/>
        /// Default Value: false
        /// </param>
        /// <param name="needLayoutVisualization">
        /// Whether to return detailed layout image result information<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startPageId">
        /// Start page number for parsing when PDF is provided
        /// </param>
        /// <param name="endPageId">
        /// End page number for parsing when PDF is provided
        /// </param>
        /// <param name="requestId">
        /// Passed by the user side, needs to be unique; used to distinguish each request, 6–64 characters. If not provided by the user side, the platform will generate one by default.
        /// </param>
        /// <param name="userId">
        /// Unique ID for the end user, 6–128 characters. Avoid using sensitive information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutParsingRequest(
            string file,
            global::ZAI.LayoutParsingRequestModel model,
            bool? returnCropImages,
            bool? needLayoutVisualization,
            int? startPageId,
            int? endPageId,
            string? requestId,
            string? userId)
        {
            this.Model = model;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.ReturnCropImages = returnCropImages;
            this.NeedLayoutVisualization = needLayoutVisualization;
            this.StartPageId = startPageId;
            this.EndPageId = endPageId;
            this.RequestId = requestId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutParsingRequest" /> class.
        /// </summary>
        public LayoutParsingRequest()
        {
        }

    }
}