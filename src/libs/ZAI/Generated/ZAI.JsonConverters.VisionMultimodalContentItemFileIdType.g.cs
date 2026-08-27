#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VisionMultimodalContentItemFileIdTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.VisionMultimodalContentItemFileIdType>
    {
        /// <inheritdoc />
        public override global::ZAI.VisionMultimodalContentItemFileIdType Read(
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
                        return global::ZAI.VisionMultimodalContentItemFileIdTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.VisionMultimodalContentItemFileIdType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.VisionMultimodalContentItemFileIdType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.VisionMultimodalContentItemFileIdType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ZAI.VisionMultimodalContentItemFileIdTypeExtensions.ToValueString(value));
        }
    }
}
