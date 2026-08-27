#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionVisionRequestModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.ChatCompletionVisionRequestModel?>
    {
        /// <inheritdoc />
        public override global::ZAI.ChatCompletionVisionRequestModel? Read(
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
                        return global::ZAI.ChatCompletionVisionRequestModelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.ChatCompletionVisionRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.ChatCompletionVisionRequestModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.ChatCompletionVisionRequestModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ZAI.ChatCompletionVisionRequestModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
