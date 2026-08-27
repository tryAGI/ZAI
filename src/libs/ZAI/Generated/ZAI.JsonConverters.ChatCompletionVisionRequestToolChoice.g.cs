#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionVisionRequestToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.ChatCompletionVisionRequestToolChoice>
    {
        /// <inheritdoc />
        public override global::ZAI.ChatCompletionVisionRequestToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ZAI.ChatCompletionVisionRequestToolChoiceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.ChatCompletionVisionRequestToolChoice)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.ChatCompletionVisionRequestToolChoice);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.ChatCompletionVisionRequestToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ZAI.ChatCompletionVisionRequestToolChoiceExtensions.ToValueString(value));
        }
    }
}
