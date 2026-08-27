#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ViduFrames2VideoRequestVariant1SizeVidu2StartEndJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd>
    {
        /// <inheritdoc />
        public override global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd Read(
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
                        return global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEndExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEndExtensions.ToValueString(value));
        }
    }
}
