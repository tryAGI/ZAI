
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestModelJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageUserMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageUserMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageSystemMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageSystemMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageAssistantMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageAssistantMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageAssistantMessageToolCallTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageAssistantMessageToolCallTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageToolMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestMessageToolMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestReasoningEffortJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestReasoningEffortNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestToolChoiceJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestToolChoiceNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestResponseFormatTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionTextRequestResponseFormatTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestModelJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageUserMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageUserMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageSystemMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageSystemMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageAssistantMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestMessageAssistantMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestReasoningEffortJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestReasoningEffortNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestToolChoiceJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatCompletionVisionRequestToolChoiceNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemTextTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemTextTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemImageTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemImageTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemAudioTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemAudioTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemAudioInputAudioFormatJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemAudioInputAudioFormatNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemVideoTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemVideoTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemFileTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemFileTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemTextTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemTextTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemImageTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemImageTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemVideoTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemVideoTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemFileTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemFileTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatThinkingTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.ChatThinkingTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchToolSchemaTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchToolSchemaTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchObjectSearchEngineJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchObjectSearchEngineNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchObjectSearchRecencyFilterJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchObjectSearchRecencyFilterNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchObjectContentSizeJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchObjectContentSizeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchObjectResultSequenceJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchObjectResultSequenceNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.FunctionToolSchemaTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.FunctionToolSchemaTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.RetrievalToolSchemaTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.RetrievalToolSchemaTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1ModelJsonConverter),

            typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1ModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1QualityJsonConverter),

            typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1QualityNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1SizeJsonConverter),

            typeof(global::ZAI.JsonConverters.CogVideoX3RequestVariant1SizeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1ModelJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1ModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1StyleJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1StyleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1AspectRatioJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1AspectRatioNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1SizeJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1SizeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1MovementAmplitudeJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestVariant1MovementAmplitudeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1ModelJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1ModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1SizeViduq1ImageJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1SizeViduq1ImageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1SizeViduq2ImageJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1SizeViduq2ImageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1MovementAmplitudeJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestVariant1MovementAmplitudeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestVariant1ModelJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestVariant1ModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestVariant1SizeViduq1StartEndJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestVariant1SizeViduq1StartEndNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestVariant1SizeVidu2StartEndJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestVariant1SizeVidu2StartEndNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestVariant1MovementAmplitudeJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestVariant1MovementAmplitudeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1ModelJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1ModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1AspectRatioJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1AspectRatioNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1SizeJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1SizeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1MovementAmplitudeJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestVariant1MovementAmplitudeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.AsyncCreateImageRequestModelJsonConverter),

            typeof(global::ZAI.JsonConverters.AsyncCreateImageRequestModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.AsyncCreateImageRequestQualityJsonConverter),

            typeof(global::ZAI.JsonConverters.AsyncCreateImageRequestQualityNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateImageRequestModelJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateImageRequestModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateImageRequestQualityJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateImageRequestQualityNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.ImageGenerationResponseContentFilterItemRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.ImageGenerationResponseContentFilterItemRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.AudioTranscriptionRequestModelJsonConverter),

            typeof(global::ZAI.JsonConverters.AudioTranscriptionRequestModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TokenizerRequestModelJsonConverter),

            typeof(global::ZAI.JsonConverters.TokenizerRequestModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TokenizerRequestMessageUserMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.TokenizerRequestMessageUserMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TokenizerRequestMessageSystemMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.TokenizerRequestMessageSystemMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TokenizerRequestMessageAssistantMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.TokenizerRequestMessageAssistantMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchRequestSearchEngineJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchRequestSearchEngineNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchRequestSearchRecencyFilterJsonConverter),

            typeof(global::ZAI.JsonConverters.WebSearchRequestSearchRecencyFilterNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestAgentIdJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestAgentIdNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestMessageContentItemTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestMessageContentItemTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesSourceLangJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesSourceLangNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesTargetLangJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesTargetLangNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesStrategyJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesStrategyNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLangJsonConverter),

            typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLangNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestAgentIdJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestAgentIdNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestMessageContentItemTextTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestMessageContentItemTextTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestCustomVariablesTemplateJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentRequestCustomVariablesTemplateNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestAgentIdJsonConverter),

            typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestAgentIdNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestMessageRoleJsonConverter),

            typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestMessageRoleNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestMessageContentItemTypeJsonConverter),

            typeof(global::ZAI.JsonConverters.GlmSlideAgentRequestMessageContentItemTypeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.LayoutParsingRequestModelJsonConverter),

            typeof(global::ZAI.JsonConverters.LayoutParsingRequestModelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.LayoutDetailLabelJsonConverter),

            typeof(global::ZAI.JsonConverters.LayoutDetailLabelNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreatePaasV4FilesRequestPurposeJsonConverter),

            typeof(global::ZAI.JsonConverters.CreatePaasV4FilesRequestPurposeNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreatePaasV4ChatCompletionsAcceptLanguageJsonConverter),

            typeof(global::ZAI.JsonConverters.CreatePaasV4ChatCompletionsAcceptLanguageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreatePaasV4VideosGenerationsAcceptLanguageJsonConverter),

            typeof(global::ZAI.JsonConverters.CreatePaasV4VideosGenerationsAcceptLanguageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.GetPaasV4AsyncResultAcceptLanguageJsonConverter),

            typeof(global::ZAI.JsonConverters.GetPaasV4AsyncResultAcceptLanguageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreatePaasV4WebSearchAcceptLanguageJsonConverter),

            typeof(global::ZAI.JsonConverters.CreatePaasV4WebSearchAcceptLanguageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateAgentsAcceptLanguageJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateAgentsAcceptLanguageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateAgentsAsyncResultAcceptLanguageJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateAgentsAsyncResultAcceptLanguageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateAgentsConversationAcceptLanguageJsonConverter),

            typeof(global::ZAI.JsonConverters.CreateAgentsConversationAcceptLanguageNullableJsonConverter),

            typeof(global::ZAI.JsonConverters.MultimodalContentItemJsonConverter),

            typeof(global::ZAI.JsonConverters.VisionMultimodalContentItemJsonConverter),

            typeof(global::ZAI.JsonConverters.CogVideoX3RequestJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduText2VideoRequestJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduImage2VideoRequestJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduFrames2VideoRequestJsonConverter),

            typeof(global::ZAI.JsonConverters.ViduReference2VideoRequestJsonConverter),

            typeof(global::ZAI.JsonConverters.SpecialEffectsVideosAgentResponseJsonConverter),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.ChatCompletionTextRequestMessageUserMessage, global::ZAI.ChatCompletionTextRequestMessageSystemMessage, global::ZAI.ChatCompletionTextRequestMessageAssistantMessage, global::ZAI.ChatCompletionTextRequestMessageToolMessage>),

            typeof(global::ZAI.JsonConverters.AnyOfJsonConverter<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.ChatCompletionVisionRequestMessageUserMessage, global::ZAI.ChatCompletionVisionRequestMessageSystemMessage, global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<string, byte[]>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<string, byte[]>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image?, global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image?>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd?, global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd?>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.TokenizerRequestMessageUserMessage, global::ZAI.TokenizerRequestMessageSystemMessage, global::ZAI.TokenizerRequestMessageAssistantMessage>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText, global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.ChatCompletionTextRequest, global::ZAI.ChatCompletionVisionRequest>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.CogVideoX3Request?, global::ZAI.ViduText2VideoRequest?, global::ZAI.ViduImage2VideoRequest?, global::ZAI.ViduFrames2VideoRequest?, global::ZAI.ViduReference2VideoRequest?>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.TranslationAgentRequest, global::ZAI.SpecialEffectsVideosAgentRequest, global::ZAI.GlmSlideAgentRequest>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.AsyncVideoGenerationResponse, global::ZAI.AsyncImageGenerationResponse>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>),

            typeof(global::ZAI.JsonConverters.OneOfJsonConverter<global::ZAI.Error, global::ZAI.SpecialEffectsVideosAgentError>),

            typeof(global::ZAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ReaderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ReaderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ReaderResponseReaderResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ReaderResponseReaderResultExternal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ZAI.ReaderResponseReaderResultExternalStylesheet2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ReaderResponseReaderResultExternalStylesheet2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ReaderResponseReaderResultMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestModel), TypeInfoPropertyName = "ChatCompletionTextRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequestMessageUserMessage, global::ZAI.ChatCompletionTextRequestMessageSystemMessage, global::ZAI.ChatCompletionTextRequestMessageAssistantMessage, global::ZAI.ChatCompletionTextRequestMessageToolMessage>>), TypeInfoPropertyName = "ChatCompletionTextRequestMessageToolMessage_1a9d2a0bae4c7122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequestMessageUserMessage, global::ZAI.ChatCompletionTextRequestMessageSystemMessage, global::ZAI.ChatCompletionTextRequestMessageAssistantMessage, global::ZAI.ChatCompletionTextRequestMessageToolMessage>), TypeInfoPropertyName = "ChatCompletionTextRequestMessageToolMessage_8827038a395281e8")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageUserMessageRole), TypeInfoPropertyName = "ChatCompletionTextRequestMessageUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageSystemMessageRole), TypeInfoPropertyName = "ChatCompletionTextRequestMessageSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageAssistantMessageRole), TypeInfoPropertyName = "ChatCompletionTextRequestMessageAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCallType), TypeInfoPropertyName = "ChatCompletionTextRequestMessageAssistantMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestMessageToolMessageRole), TypeInfoPropertyName = "ChatCompletionTextRequestMessageToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestReasoningEffort), TypeInfoPropertyName = "ChatCompletionTextRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>), TypeInfoPropertyName = "AnyOfFunctionToolSchemaRetrievalToolSchemaWebSearchToolSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.FunctionToolSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.RetrievalToolSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchToolSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestToolChoice), TypeInfoPropertyName = "ChatCompletionTextRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionTextRequestResponseFormatType), TypeInfoPropertyName = "ChatCompletionTextRequestResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestModel), TypeInfoPropertyName = "ChatCompletionVisionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.ChatCompletionVisionRequestMessageUserMessage, global::ZAI.ChatCompletionVisionRequestMessageSystemMessage, global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage>>), TypeInfoPropertyName = "ChatCompletionVisionRequestMessageAssistantMessage_51f64b6599c045a3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.ChatCompletionVisionRequestMessageUserMessage, global::ZAI.ChatCompletionVisionRequestMessageSystemMessage, global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage>), TypeInfoPropertyName = "ChatCompletionVisionRequestMessageAssistantMessage_02bf85c1293edabd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestMessageUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestMessageUserMessageRole), TypeInfoPropertyName = "ChatCompletionVisionRequestMessageUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string>), TypeInfoPropertyName = "OneOfIListVisionMultimodalContentItemString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItem), TypeInfoPropertyName = "VisionMultimodalContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestMessageSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestMessageSystemMessageRole), TypeInfoPropertyName = "ChatCompletionVisionRequestMessageSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestMessageAssistantMessageRole), TypeInfoPropertyName = "ChatCompletionVisionRequestMessageAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestReasoningEffort), TypeInfoPropertyName = "ChatCompletionVisionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.FunctionToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionVisionRequestToolChoice), TypeInfoPropertyName = "ChatCompletionVisionRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItem), TypeInfoPropertyName = "MultimodalContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemTextType), TypeInfoPropertyName = "MultimodalContentItemTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemImageType), TypeInfoPropertyName = "MultimodalContentItemImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemAudioType), TypeInfoPropertyName = "MultimodalContentItemAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemAudioInputAudioFormat), TypeInfoPropertyName = "MultimodalContentItemAudioInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemVideoType), TypeInfoPropertyName = "MultimodalContentItemVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemVideoVideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemFileType), TypeInfoPropertyName = "MultimodalContentItemFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.MultimodalContentItemFileFileUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemTextType), TypeInfoPropertyName = "VisionMultimodalContentItemTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemImageType), TypeInfoPropertyName = "VisionMultimodalContentItemImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemVideoType), TypeInfoPropertyName = "VisionMultimodalContentItemVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemVideoVideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemFileType), TypeInfoPropertyName = "VisionMultimodalContentItemFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VisionMultimodalContentItemFileFileUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatThinkingType), TypeInfoPropertyName = "ChatThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchToolSchemaType), TypeInfoPropertyName = "WebSearchToolSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchObjectSearchEngine), TypeInfoPropertyName = "WebSearchObjectSearchEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchObjectSearchRecencyFilter), TypeInfoPropertyName = "WebSearchObjectSearchRecencyFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchObjectContentSize), TypeInfoPropertyName = "WebSearchObjectContentSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchObjectResultSequence), TypeInfoPropertyName = "WebSearchObjectResultSequence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.FunctionToolSchemaType), TypeInfoPropertyName = "FunctionToolSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.FunctionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.FunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.RetrievalToolSchemaType), TypeInfoPropertyName = "RetrievalToolSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.RetrievalObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionResponseUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionResponseMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ChatCompletionResponseMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CogVideoX3Request), TypeInfoPropertyName = "CogVideoX3Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CogVideoX3RequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CogVideoX3RequestVariant1Model), TypeInfoPropertyName = "CogVideoX3RequestVariant1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CogVideoX3RequestVariant1Quality), TypeInfoPropertyName = "CogVideoX3RequestVariant1Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.OneOf<string, byte[]>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<string, byte[]>), TypeInfoPropertyName = "OneOfStringByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CogVideoX3RequestVariant1Size), TypeInfoPropertyName = "CogVideoX3RequestVariant1Size2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VideoCommonRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduText2VideoRequest), TypeInfoPropertyName = "ViduText2VideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduText2VideoRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduText2VideoRequestVariant1Model), TypeInfoPropertyName = "ViduText2VideoRequestVariant1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduText2VideoRequestVariant1Style), TypeInfoPropertyName = "ViduText2VideoRequestVariant1Style2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduText2VideoRequestVariant1AspectRatio), TypeInfoPropertyName = "ViduText2VideoRequestVariant1AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduText2VideoRequestVariant1Size), TypeInfoPropertyName = "ViduText2VideoRequestVariant1Size2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduText2VideoRequestVariant1MovementAmplitude), TypeInfoPropertyName = "ViduText2VideoRequestVariant1MovementAmplitude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduImage2VideoRequest), TypeInfoPropertyName = "ViduImage2VideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduImage2VideoRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduImage2VideoRequestVariant1Model), TypeInfoPropertyName = "ViduImage2VideoRequestVariant1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image?, global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image?>), TypeInfoPropertyName = "OneOfViduImage2VideoRequestVariant1SizeViduq1ImageViduImage2VideoRequestVariant1SizeViduq2Image2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image), TypeInfoPropertyName = "ViduImage2VideoRequestVariant1SizeViduq1Image2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image), TypeInfoPropertyName = "ViduImage2VideoRequestVariant1SizeViduq2Image2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduImage2VideoRequestVariant1MovementAmplitude), TypeInfoPropertyName = "ViduImage2VideoRequestVariant1MovementAmplitude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduFrames2VideoRequest), TypeInfoPropertyName = "ViduFrames2VideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduFrames2VideoRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduFrames2VideoRequestVariant1Model), TypeInfoPropertyName = "ViduFrames2VideoRequestVariant1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd?, global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd?>), TypeInfoPropertyName = "OneOfViduFrames2VideoRequestVariant1SizeViduq1StartEndViduFrames2VideoRequestVariant1SizeVidu2StartEnd2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd), TypeInfoPropertyName = "ViduFrames2VideoRequestVariant1SizeViduq1StartEnd2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd), TypeInfoPropertyName = "ViduFrames2VideoRequestVariant1SizeVidu2StartEnd2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduFrames2VideoRequestVariant1MovementAmplitude), TypeInfoPropertyName = "ViduFrames2VideoRequestVariant1MovementAmplitude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduReference2VideoRequest), TypeInfoPropertyName = "ViduReference2VideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduReference2VideoRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduReference2VideoRequestVariant1Model), TypeInfoPropertyName = "ViduReference2VideoRequestVariant1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduReference2VideoRequestVariant1AspectRatio), TypeInfoPropertyName = "ViduReference2VideoRequestVariant1AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduReference2VideoRequestVariant1Size), TypeInfoPropertyName = "ViduReference2VideoRequestVariant1Size2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude), TypeInfoPropertyName = "ViduReference2VideoRequestVariant1MovementAmplitude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AsyncCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AsyncCreateImageRequestModel), TypeInfoPropertyName = "AsyncCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AsyncCreateImageRequestQuality), TypeInfoPropertyName = "AsyncCreateImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AsyncVideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.AsyncVideoGenerationResponseVideoResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AsyncVideoGenerationResponseVideoResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AsyncImageGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.AsyncImageGenerationResponseImageResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AsyncImageGenerationResponseImageResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.VideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreateImageRequestModel), TypeInfoPropertyName = "CreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreateImageRequestQuality), TypeInfoPropertyName = "CreateImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ImageGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ImageGenerationResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseContentFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ImageGenerationResponseContentFilterItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.ImageGenerationResponseContentFilterItemRole), TypeInfoPropertyName = "ImageGenerationResponseContentFilterItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AudioTranscriptionRequestModel), TypeInfoPropertyName = "AudioTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AudioTranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.AudioTranscriptionStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerRequestModel), TypeInfoPropertyName = "TokenizerRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.TokenizerRequestMessageUserMessage, global::ZAI.TokenizerRequestMessageSystemMessage, global::ZAI.TokenizerRequestMessageAssistantMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.TokenizerRequestMessageUserMessage, global::ZAI.TokenizerRequestMessageSystemMessage, global::ZAI.TokenizerRequestMessageAssistantMessage>), TypeInfoPropertyName = "OneOfTokenizerRequestMessageUserMessageTokenizerRequestMessageSystemMessageTokenizerRequestMessageAssistantMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerRequestMessageUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerRequestMessageUserMessageRole), TypeInfoPropertyName = "TokenizerRequestMessageUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerRequestMessageSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerRequestMessageSystemMessageRole), TypeInfoPropertyName = "TokenizerRequestMessageSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerRequestMessageAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerRequestMessageAssistantMessageRole), TypeInfoPropertyName = "TokenizerRequestMessageAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TokenizerResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchRequestSearchEngine), TypeInfoPropertyName = "WebSearchRequestSearchEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchRequestSearchRecencyFilter), TypeInfoPropertyName = "WebSearchRequestSearchRecencyFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.WebSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestAgentId), TypeInfoPropertyName = "TranslationAgentRequestAgentId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestMessageRole), TypeInfoPropertyName = "TranslationAgentRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestMessageContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestMessageContentItemType), TypeInfoPropertyName = "TranslationAgentRequestMessageContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestCustomVariables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestCustomVariablesSourceLang), TypeInfoPropertyName = "TranslationAgentRequestCustomVariablesSourceLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestCustomVariablesTargetLang), TypeInfoPropertyName = "TranslationAgentRequestCustomVariablesTargetLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestCustomVariablesStrategy), TypeInfoPropertyName = "TranslationAgentRequestCustomVariablesStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigGeneral))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang), TypeInfoPropertyName = "TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.TranslationAgentResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentResponseChoiceMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentResponseChoiceMessagesContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.TranslationAgentResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestAgentId), TypeInfoPropertyName = "SpecialEffectsVideosAgentRequestAgentId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.SpecialEffectsVideosAgentRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestMessageRole), TypeInfoPropertyName = "SpecialEffectsVideosAgentRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.OneOf<global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText, global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl>>), TypeInfoPropertyName = "SpecialEffectsVideosAgentRequestMessageContentItemImageUrl_d907fb6aa0b1f556")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText, global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl>), TypeInfoPropertyName = "OneOfSpecialEffectsVideosAgentRequestMessageContentItemTextSpecialEffectsVideosAgentRequestMessageContentItemImageUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemTextType), TypeInfoPropertyName = "SpecialEffectsVideosAgentRequestMessageContentItemTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType), TypeInfoPropertyName = "SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestCustomVariables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentRequestCustomVariablesTemplate), TypeInfoPropertyName = "SpecialEffectsVideosAgentRequestCustomVariablesTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentResponse), TypeInfoPropertyName = "SpecialEffectsVideosAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.SpecialEffectsVideosAgentErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentRequestAgentId), TypeInfoPropertyName = "GlmSlideAgentRequestAgentId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentRequestMessageRole), TypeInfoPropertyName = "GlmSlideAgentRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentRequestMessageContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentRequestMessageContentItemType), TypeInfoPropertyName = "GlmSlideAgentRequestMessageContentItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentResponseChoiceMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItemObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CommonAgentResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentConversationRequestCustomVariables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentConversationResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GlmSlideAgentConversationResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CommonAgentResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CommonAgentResultResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CommonAgentResultResponseChoiceMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.LayoutParsingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.LayoutParsingRequestModel), TypeInfoPropertyName = "LayoutParsingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.LayoutParsingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.LayoutDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.DataInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.LayoutParsingResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.LayoutParsingResponseUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.LayoutDetailLabel), TypeInfoPropertyName = "LayoutDetailLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ZAI.PageInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.BadRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.UnauthorizedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.NotFoundData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequest, global::ZAI.ChatCompletionVisionRequest>), TypeInfoPropertyName = "OneOfChatCompletionTextRequestChatCompletionVisionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.CogVideoX3Request?, global::ZAI.ViduText2VideoRequest?, global::ZAI.ViduImage2VideoRequest?, global::ZAI.ViduFrames2VideoRequest?, global::ZAI.ViduReference2VideoRequest?>), TypeInfoPropertyName = "OneOfCogVideoX3RequestViduText2VideoRequestViduImage2VideoRequestViduFrames2VideoRequestViduReference2VideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreatePaasV4FilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreatePaasV4FilesRequestPurpose), TypeInfoPropertyName = "CreatePaasV4FilesRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.TranslationAgentRequest, global::ZAI.SpecialEffectsVideosAgentRequest, global::ZAI.GlmSlideAgentRequest>), TypeInfoPropertyName = "OneOfTranslationAgentRequestSpecialEffectsVideosAgentRequestGlmSlideAgentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreatePaasV4ChatCompletionsAcceptLanguage), TypeInfoPropertyName = "CreatePaasV4ChatCompletionsAcceptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreatePaasV4VideosGenerationsAcceptLanguage), TypeInfoPropertyName = "CreatePaasV4VideosGenerationsAcceptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.GetPaasV4AsyncResultAcceptLanguage), TypeInfoPropertyName = "GetPaasV4AsyncResultAcceptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreatePaasV4WebSearchAcceptLanguage), TypeInfoPropertyName = "CreatePaasV4WebSearchAcceptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreateAgentsAcceptLanguage), TypeInfoPropertyName = "CreateAgentsAcceptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreateAgentsAsyncResultAcceptLanguage), TypeInfoPropertyName = "CreateAgentsAsyncResultAcceptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreateAgentsConversationAcceptLanguage), TypeInfoPropertyName = "CreateAgentsConversationAcceptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.AsyncVideoGenerationResponse, global::ZAI.AsyncImageGenerationResponse>), TypeInfoPropertyName = "OneOfAsyncVideoGenerationResponseAsyncImageGenerationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.CreatePaasV4FilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>), TypeInfoPropertyName = "OneOfTranslationAgentResponseSpecialEffectsVideosAgentResponseGlmSlideAgentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.Error, global::ZAI.SpecialEffectsVideosAgentError>), TypeInfoPropertyName = "OneOfErrorSpecialEffectsVideosAgentError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequestMessageUserMessage, global::ZAI.ChatCompletionTextRequestMessageSystemMessage, global::ZAI.ChatCompletionTextRequestMessageAssistantMessage, global::ZAI.ChatCompletionTextRequestMessageToolMessage>?), TypeInfoPropertyName = "ChatCompletionTextRequestMessageToolMessage_9a4891dcac3e71ad")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.ChatCompletionVisionRequestMessageUserMessage, global::ZAI.ChatCompletionVisionRequestMessageSystemMessage, global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage>?), TypeInfoPropertyName = "ChatCompletionVisionRequestMessageAssistantMessage_51e5b68790c6bf6d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.TokenizerRequestMessageUserMessage, global::ZAI.TokenizerRequestMessageSystemMessage, global::ZAI.TokenizerRequestMessageAssistantMessage>?), TypeInfoPropertyName = "TokenizerRequestMessageAssistantMessage_e137f001fef9025b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText, global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl>?), TypeInfoPropertyName = "SpecialEffectsVideosAgentRequestMessageContentItemImageUrl_18cc3b2916008645")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::ZAI.CogVideoX3Request?, global::ZAI.ViduText2VideoRequest?, global::ZAI.ViduImage2VideoRequest?, global::ZAI.ViduFrames2VideoRequest?, global::ZAI.ViduReference2VideoRequest?>?), TypeInfoPropertyName = "ViduReference2VideoRequest_be462ac2034622a9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequestMessageUserMessage, global::ZAI.ChatCompletionTextRequestMessageSystemMessage, global::ZAI.ChatCompletionTextRequestMessageAssistantMessage, global::ZAI.ChatCompletionTextRequestMessageToolMessage>>), TypeInfoPropertyName = "ChatCompletionTextRequestMessageToolMessage_d0ac140de832b39e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.OneOf<global::ZAI.ChatCompletionVisionRequestMessageUserMessage, global::ZAI.ChatCompletionVisionRequestMessageSystemMessage, global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage>>), TypeInfoPropertyName = "ChatCompletionVisionRequestMessageAssistantMessage_f4b3b8725743f573")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ZAI.OneOf<global::System.Collections.Generic.List<global::ZAI.VisionMultimodalContentItem>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.VisionMultimodalContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.FunctionToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.WebSearchObjectResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.ChatCompletionResponseMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.OneOf<string, byte[]>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.AsyncVideoGenerationResponseVideoResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.AsyncImageGenerationResponseImageResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.ImageGenerationResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.ImageGenerationResponseContentFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.OneOf<global::ZAI.TokenizerRequestMessageUserMessage, global::ZAI.TokenizerRequestMessageSystemMessage, global::ZAI.TokenizerRequestMessageAssistantMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.TranslationAgentRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.TranslationAgentRequestMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.TranslationAgentResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.SpecialEffectsVideosAgentRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.OneOf<global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText, global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl>>), TypeInfoPropertyName = "SpecialEffectsVideosAgentRequestMessageContentItemImageUrl_50faece637fba52c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentRequestMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentConversationResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.CommonAgentResultResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.CommonAgentResultResponseChoiceMessageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::ZAI.LayoutDetail>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.LayoutDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ZAI.PageInfo>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}