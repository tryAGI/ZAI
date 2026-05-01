
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Output format type: text for plain text, json_object for JSON-formatted output.<br/>
    /// Default Value: text
    /// </summary>
    public enum ChatCompletionTextRequestResponseFormatType
    {
        /// <summary>
        /// text for plain text, json_object for JSON-formatted output.
        /// </summary>
        JsonObject,
        /// <summary>
        /// text for plain text, json_object for JSON-formatted output.
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionTextRequestResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionTextRequestResponseFormatType value)
        {
            return value switch
            {
                ChatCompletionTextRequestResponseFormatType.JsonObject => "json_object",
                ChatCompletionTextRequestResponseFormatType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionTextRequestResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ChatCompletionTextRequestResponseFormatType.JsonObject,
                "text" => ChatCompletionTextRequestResponseFormatType.Text,
                _ => null,
            };
        }
    }
}