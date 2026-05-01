#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebSearchToolSchemaTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.WebSearchToolSchemaType>
    {
        /// <inheritdoc />
        public override global::ZAI.WebSearchToolSchemaType Read(
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
                        return global::ZAI.WebSearchToolSchemaTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.WebSearchToolSchemaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.WebSearchToolSchemaType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.WebSearchToolSchemaType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ZAI.WebSearchToolSchemaTypeExtensions.ToValueString(value));
        }
    }
}
