#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CogVideoX3RequestVariant1QualityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.CogVideoX3RequestVariant1Quality?>
    {
        /// <inheritdoc />
        public override global::ZAI.CogVideoX3RequestVariant1Quality? Read(
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
                        return global::ZAI.CogVideoX3RequestVariant1QualityExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.CogVideoX3RequestVariant1Quality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.CogVideoX3RequestVariant1Quality?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.CogVideoX3RequestVariant1Quality? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ZAI.CogVideoX3RequestVariant1QualityExtensions.ToValueString(value.Value));
            }
        }
    }
}
