#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ZAI.JsonConverters
{
    /// <inheritdoc />
    public class ViduFrames2VideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ZAI.ViduFrames2VideoRequest>
    {
        /// <inheritdoc />
        public override global::ZAI.ViduFrames2VideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("duration")) __score0++;
            if (__jsonProps.Contains("image_url")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("movement_amplitude")) __score0++;
            if (__jsonProps.Contains("prompt")) __score0++;
            if (__jsonProps.Contains("size")) __score0++;
            if (__jsonProps.Contains("with_audio")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("request_id")) __score1++;
            if (__jsonProps.Contains("user_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::ZAI.ViduFrames2VideoRequestVariant1? viduFrames2VideoRequestVariant1 = default;
            global::ZAI.VideoCommonRequest? common = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.ViduFrames2VideoRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.ViduFrames2VideoRequestVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.ViduFrames2VideoRequestVariant1).Name}");
                        viduFrames2VideoRequestVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.VideoCommonRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.VideoCommonRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.VideoCommonRequest).Name}");
                        common = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (viduFrames2VideoRequestVariant1 == null && common == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.ViduFrames2VideoRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.ViduFrames2VideoRequestVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.ViduFrames2VideoRequestVariant1).Name}");
                    viduFrames2VideoRequestVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.VideoCommonRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.VideoCommonRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.VideoCommonRequest).Name}");
                    common = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ZAI.ViduFrames2VideoRequest(
                viduFrames2VideoRequestVariant1,

                common
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ZAI.ViduFrames2VideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsViduFrames2VideoRequestVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.ViduFrames2VideoRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.ViduFrames2VideoRequestVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.ViduFrames2VideoRequestVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ViduFrames2VideoRequestVariant1!, typeInfo);
            }
            else if (value.IsCommon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ZAI.VideoCommonRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ZAI.VideoCommonRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ZAI.VideoCommonRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Common!, typeInfo);
            }
        }
    }
}