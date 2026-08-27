#nullable enable

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ViduText2VideoRequestVariant1AspectRatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.ViduText2VideoRequestVariant1AspectRatio>
    {
        /// <inheritdoc />
        public override global::ZAI.ViduText2VideoRequestVariant1AspectRatio Read(
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
                        return global::ZAI.ViduText2VideoRequestVariant1AspectRatioExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ZAI.ViduText2VideoRequestVariant1AspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ZAI.ViduText2VideoRequestVariant1AspectRatio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.ViduText2VideoRequestVariant1AspectRatio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ZAI.ViduText2VideoRequestVariant1AspectRatioExtensions.ToValueString(value));
        }
    }
}
