
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchObjectResponse
    {
        /// <summary>
        /// Title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Content summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Result URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Website name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public string? Media { get; set; }

        /// <summary>
        /// Website icon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Index number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refer")]
        public string? Refer { get; set; }

        /// <summary>
        /// Website publication date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publish_date")]
        public string? PublishDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchObjectResponse" /> class.
        /// </summary>
        /// <param name="title">
        /// Title.
        /// </param>
        /// <param name="content">
        /// Content summary.
        /// </param>
        /// <param name="link">
        /// Result URL.
        /// </param>
        /// <param name="media">
        /// Website name.
        /// </param>
        /// <param name="icon">
        /// Website icon.
        /// </param>
        /// <param name="refer">
        /// Index number.
        /// </param>
        /// <param name="publishDate">
        /// Website publication date.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchObjectResponse(
            string? title,
            string? content,
            string? link,
            string? media,
            string? icon,
            string? refer,
            string? publishDate)
        {
            this.Title = title;
            this.Content = content;
            this.Link = link;
            this.Media = media;
            this.Icon = icon;
            this.Refer = refer;
            this.PublishDate = publishDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchObjectResponse" /> class.
        /// </summary>
        public WebSearchObjectResponse()
        {
        }

    }
}