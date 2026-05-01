
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Page dimension information
    /// </summary>
    public sealed partial class PageInfo
    {
        /// <summary>
        /// Page width<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Page height<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo" /> class.
        /// </summary>
        /// <param name="width">
        /// Page width<br/>
        /// Example: 600
        /// </param>
        /// <param name="height">
        /// Page height<br/>
        /// Example: 800
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageInfo(
            int width,
            int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo" /> class.
        /// </summary>
        public PageInfo()
        {
        }
    }
}