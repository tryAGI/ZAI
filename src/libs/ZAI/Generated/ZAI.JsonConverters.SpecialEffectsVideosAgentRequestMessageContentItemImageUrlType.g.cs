#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpecialEffectsVideosAgentRequestMessageContentItemImageUrlTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType>
    {
        /// <inheritdoc />
        public override global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType Read(
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
                        return global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlTypeExtensions.ToValueString(value));
        }
    }
}
