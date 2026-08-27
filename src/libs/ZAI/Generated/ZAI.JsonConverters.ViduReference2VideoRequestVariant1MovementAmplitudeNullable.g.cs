#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ViduReference2VideoRequestVariant1MovementAmplitudeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude?>
    {
        /// <inheritdoc />
        public override global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude? Read(
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
                        return global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitudeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitudeExtensions.ToValueString(value.Value));
            }
        }
    }
}
