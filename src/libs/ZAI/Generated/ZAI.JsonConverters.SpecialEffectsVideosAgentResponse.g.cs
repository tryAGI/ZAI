#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public class SpecialEffectsVideosAgentResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.SpecialEffectsVideosAgentResponse>
    {
        /// <inheritdoc />
        public override global::ZAI.SpecialEffectsVideosAgentResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::ZAI.SpecialEffectsVideosAgentResponseVariant1? specialEffectsVideosAgentResponseVariant1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.SpecialEffectsVideosAgentResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.SpecialEffectsVideosAgentResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.SpecialEffectsVideosAgentResponseVariant1).Name}");
                specialEffectsVideosAgentResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::ZAI.SpecialEffectsVideosAgentError? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.SpecialEffectsVideosAgentError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.SpecialEffectsVideosAgentError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.SpecialEffectsVideosAgentError).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::ZAI.SpecialEffectsVideosAgentResponse(
                specialEffectsVideosAgentResponseVariant1,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.SpecialEffectsVideosAgentResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsSpecialEffectsVideosAgentResponseVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.SpecialEffectsVideosAgentResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.SpecialEffectsVideosAgentResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.SpecialEffectsVideosAgentResponseVariant1).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SpecialEffectsVideosAgentResponseVariant1!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.SpecialEffectsVideosAgentError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.SpecialEffectsVideosAgentError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.SpecialEffectsVideosAgentError).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Error!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}