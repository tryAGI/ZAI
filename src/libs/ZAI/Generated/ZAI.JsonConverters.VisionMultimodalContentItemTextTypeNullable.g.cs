#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VisionMultimodalContentItemTextTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.VisionMultimodalContentItemTextType?>
    {
        /// <inheritdoc />
        public override global::ZAI.VisionMultimodalContentItemTextType? Read(
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
                        return global::ZAI.VisionMultimodalContentItemTextTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.VisionMultimodalContentItemTextType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.VisionMultimodalContentItemTextType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.VisionMultimodalContentItemTextType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ZAI.VisionMultimodalContentItemTextTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
