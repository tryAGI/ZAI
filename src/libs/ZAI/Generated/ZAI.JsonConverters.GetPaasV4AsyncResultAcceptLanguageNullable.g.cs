#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPaasV4AsyncResultAcceptLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.GetPaasV4AsyncResultAcceptLanguage?>
    {
        /// <inheritdoc />
        public override global::ZAI.GetPaasV4AsyncResultAcceptLanguage? Read(
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
                        return global::ZAI.GetPaasV4AsyncResultAcceptLanguageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.GetPaasV4AsyncResultAcceptLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.GetPaasV4AsyncResultAcceptLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.GetPaasV4AsyncResultAcceptLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ZAI.GetPaasV4AsyncResultAcceptLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
