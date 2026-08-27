#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class AsyncCreateImageRequestQualityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.AsyncCreateImageRequestQuality?>
    {
        /// <inheritdoc />
        public override global::ZAI.AsyncCreateImageRequestQuality? Read(
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
                        return global::ZAI.AsyncCreateImageRequestQualityExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.AsyncCreateImageRequestQuality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.AsyncCreateImageRequestQuality?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.AsyncCreateImageRequestQuality? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ZAI.AsyncCreateImageRequestQualityExtensions.ToValueString(value.Value));
            }
        }
    }
}
