
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Layout detail element
    /// </summary>
    public sealed partial class LayoutDetail
    {
        /// <summary>
        /// Element index<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Element type: image for images, text for text content, formula for inline formulas, table for tables<br/>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.LayoutDetailLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ZAI.LayoutDetailLabel Label { get; set; }

        /// <summary>
        /// Normalized element coordinates [x1,y1,x2,y2]<br/>
        /// Example: [0.1F, 0.1F, 0.5F, 0.3F]
        /// </summary>
        /// <example>[0.1F, 0.1F, 0.5F, 0.3F]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_2d")]
        public global::System.Collections.Generic.IList<double>? Bbox2d { get; set; }

        /// <summary>
        /// Element content (text / image URL / table HTML)<br/>
        /// Example: This is the content of the element
        /// </summary>
        /// <example>This is the content of the element</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Page height<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Page width<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutDetail" /> class.
        /// </summary>
        /// <param name="index">
        /// Element index<br/>
        /// Example: 1
        /// </param>
        /// <param name="label">
        /// Element type: image for images, text for text content, formula for inline formulas, table for tables<br/>
        /// Example: text
        /// </param>
        /// <param name="bbox2d">
        /// Normalized element coordinates [x1,y1,x2,y2]<br/>
        /// Example: [0.1F, 0.1F, 0.5F, 0.3F]
        /// </param>
        /// <param name="content">
        /// Element content (text / image URL / table HTML)<br/>
        /// Example: This is the content of the element
        /// </param>
        /// <param name="height">
        /// Page height<br/>
        /// Example: 800
        /// </param>
        /// <param name="width">
        /// Page width<br/>
        /// Example: 600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayoutDetail(
            int index,
            global::ZAI.LayoutDetailLabel label,
            global::System.Collections.Generic.IList<double>? bbox2d,
            string? content,
            int? height,
            int? width)
        {
            this.Index = index;
            this.Label = label;
            this.Bbox2d = bbox2d;
            this.Content = content;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutDetail" /> class.
        /// </summary>
        public LayoutDetail()
        {
        }

    }
}