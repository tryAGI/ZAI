
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Output object content when type is object
    /// </summary>
    public sealed partial class GlmSlideAgentResponseChoiceMessageItemContentItemObject
    {
        /// <summary>
        /// Tool name eg: search、insert_page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// Tool input content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Tool output content, will output html when generate slide
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// If the tool involves operations on a PPT file, the position field specifies which slides are being manipulated.<br/>
        ///  If the user says, “Insert a slide after the second slide,” then position = [3], and the output is the HTML content of the third slide.<br/>
        ///  If the user says, “Please delete slides 4, 5, and 6,” then position = [4, 5, 6].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::System.Collections.Generic.IList<double>? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponseChoiceMessageItemContentItemObject" /> class.
        /// </summary>
        /// <param name="toolName">
        /// Tool name eg: search、insert_page
        /// </param>
        /// <param name="input">
        /// Tool input content
        /// </param>
        /// <param name="output">
        /// Tool output content, will output html when generate slide
        /// </param>
        /// <param name="position">
        /// If the tool involves operations on a PPT file, the position field specifies which slides are being manipulated.<br/>
        ///  If the user says, “Insert a slide after the second slide,” then position = [3], and the output is the HTML content of the third slide.<br/>
        ///  If the user says, “Please delete slides 4, 5, and 6,” then position = [4, 5, 6].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlmSlideAgentResponseChoiceMessageItemContentItemObject(
            string? toolName,
            string? input,
            string? output,
            global::System.Collections.Generic.IList<double>? position)
        {
            this.ToolName = toolName;
            this.Input = input;
            this.Output = output;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlmSlideAgentResponseChoiceMessageItemContentItemObject" /> class.
        /// </summary>
        public GlmSlideAgentResponseChoiceMessageItemContentItemObject()
        {
        }

    }
}