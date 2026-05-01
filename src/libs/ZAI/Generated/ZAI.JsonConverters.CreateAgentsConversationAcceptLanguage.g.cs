#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAgentsConversationAcceptLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.CreateAgentsConversationAcceptLanguage>
    {
        /// <inheritdoc />
        public override global::ZAI.CreateAgentsConversationAcceptLanguage Read(
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
                        return global::ZAI.CreateAgentsConversationAcceptLanguageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.CreateAgentsConversationAcceptLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.CreateAgentsConversationAcceptLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.CreateAgentsConversationAcceptLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ZAI.CreateAgentsConversationAcceptLanguageExtensions.ToValueString(value));
        }
    }
}
