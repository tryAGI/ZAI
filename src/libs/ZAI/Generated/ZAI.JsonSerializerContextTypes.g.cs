
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ZAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ReaderRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ReaderResponse? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ReaderResponseReaderResult? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ReaderResponseReaderResultExternal? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ZAI.ReaderResponseReaderResultExternalStylesheet2>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ReaderResponseReaderResultExternalStylesheet2? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ReaderResponseReaderResultMetadata? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestModel? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageUserMessage? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageUserMessageRole? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageSystemMessage? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageSystemMessageRole? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageAssistantMessage? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageAssistantMessageRole? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCall>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCall? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCallType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCallFunction? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageToolMessage? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestMessageToolMessageRole? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatThinking? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestReasoningEffort? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.FunctionToolSchema? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.RetrievalToolSchema? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchToolSchema? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestToolChoice? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestResponseFormat? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestResponseFormatType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestModel? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageUserMessage? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageUserMessageRole? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItem? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageSystemMessage? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageSystemMessageRole? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageAssistantMessageRole? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestReasoningEffort? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.FunctionToolSchema>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestToolChoice? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemText? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemTextType? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImage? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImageType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImageImageUrl? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideo? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideoType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideoVideoUrl? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFile? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFileType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFileFile? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatThinkingType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchToolSchemaType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObject? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectSearchEngine? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectSearchRecencyFilter? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectContentSize? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectResultSequence? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.FunctionToolSchemaType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.FunctionObject? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.FunctionParameters? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.RetrievalToolSchemaType? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.RetrievalObject? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseChoice>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseChoice? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessage? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseUsage? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseUsagePromptTokensDetails? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectResponse? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseMessageToolCall>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessageToolCall? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessageToolCallFunction? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3Request? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Model? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Quality? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.OneOf<string, byte[]>>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<string, byte[]>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Size? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VideoCommonRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncCreateImageRequest? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncCreateImageRequestModel? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncCreateImageRequestQuality? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncVideoGenerationResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AsyncVideoGenerationResponseVideoResultItem>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncVideoGenerationResponseVideoResultItem? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncImageGenerationResponse? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AsyncImageGenerationResponseImageResultItem>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncImageGenerationResponseImageResultItem? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VideoResponse? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateImageRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateImageRequestModel? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateImageRequestQuality? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ImageGenerationResponse? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseDataItem>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ImageGenerationResponseDataItem? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseContentFilterItem>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ImageGenerationResponseContentFilterItem? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ImageGenerationResponseContentFilterItemRole? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AudioTranscriptionRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AudioTranscriptionRequestModel? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AudioTranscriptionResponse? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AudioTranscriptionStreamResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestModel? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageUserMessage? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageUserMessageRole? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageSystemMessage? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageSystemMessageRole? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageAssistantMessage? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageAssistantMessageRole? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerResponseUsage? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchRequest? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchRequestSearchEngine? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchRequestSearchRecencyFilter? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequest? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestAgentId? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessage>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessage? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageRole? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessageContentItem>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageContentItem? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageContentItemType? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariables? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesSourceLang? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesTargetLang? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategy? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfig? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigGeneral? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCot? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponse? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentResponseChoice>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoice? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoiceMessages? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoiceMessagesContent? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponseUsage? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestAgentId? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.SpecialEffectsVideosAgentRequestMessage>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessage? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageRole? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemTextType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariables? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariablesTemplate? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponse? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponseVariant1? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentError? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentErrorError? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestAgentId? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessage>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessage? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageRole? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessageContentItem>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageContentItem? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageContentItemType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoice>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoice? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItem? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItemObject? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseError? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultRequest? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequest? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariables? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponse? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoice>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoice? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseError? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultResponse? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoice>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoice? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItem>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoiceMessageItem? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingRequest? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingRequestModel? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutDetail? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.DataInfo? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingResponseUsage? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingResponseUsagePromptTokensDetails? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutDetailLabel? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.PageInfo>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.PageInfo? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.BadRequestData? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.UnauthorizedData? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.NotFoundData? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.Error? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequest, global::ZAI.ChatCompletionVisionRequest>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4FilesRequest? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4FilesRequestPurpose? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.TranslationAgentRequest, global::ZAI.SpecialEffectsVideosAgentRequest, global::ZAI.GlmSlideAgentRequest>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4ChatCompletionsAcceptLanguage? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4VideosGenerationsAcceptLanguage? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GetPaasV4AsyncResultAcceptLanguage? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4WebSearchAcceptLanguage? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateAgentsAcceptLanguage? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateAgentsAsyncResultAcceptLanguage? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateAgentsConversationAcceptLanguage? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.AsyncVideoGenerationResponse, global::ZAI.AsyncImageGenerationResponse>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4FilesResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.Error, global::ZAI.SpecialEffectsVideosAgentError>? Type240 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.ChatCompletionTextRequestMessageAssistantMessageToolCall>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::System.Collections.Generic.List<global::ZAI.VisionMultimodalContentItem>, string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.VisionMultimodalContentItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.FunctionToolSchema>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.ChatCompletionResponseChoice>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.WebSearchObjectResponse>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.ChatCompletionResponseMessageToolCall>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.OneOf<string, byte[]>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.AsyncVideoGenerationResponseVideoResultItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.AsyncImageGenerationResponseImageResultItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.ImageGenerationResponseDataItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.ImageGenerationResponseContentFilterItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.TranslationAgentRequestMessage>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.TranslationAgentRequestMessageContentItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.TranslationAgentResponseChoice>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.SpecialEffectsVideosAgentRequestMessage>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentRequestMessage>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentRequestMessageContentItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentResponseChoice>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentConversationResponseChoice>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.CommonAgentResultResponseChoice>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.CommonAgentResultResponseChoiceMessageItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::ZAI.LayoutDetail>>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.LayoutDetail>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ZAI.PageInfo>? ListType33 { get; set; }
    }
}