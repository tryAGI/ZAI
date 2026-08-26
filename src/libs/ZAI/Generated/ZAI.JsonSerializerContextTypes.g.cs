
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
        public global::ZAI.MultimodalContentItem? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemText? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemTextType? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemImage? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemImageType? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemImageImageUrl? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemAudio? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemAudioType? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemAudioInputAudio? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemAudioInputAudioFormat? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemVideo? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemVideoType? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemVideoVideoUrl? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemFile? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemFileType? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemFileFileUrl? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemText? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemTextType? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImage? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImageType? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImageImageUrl? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideo? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideoType? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideoVideoUrl? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFile? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFileType? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFileFileUrl? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatThinkingType? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchToolSchemaType? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObject? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectSearchEngine? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectSearchRecencyFilter? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectContentSize? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectResultSequence? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.FunctionToolSchemaType? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.FunctionObject? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.FunctionParameters? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.RetrievalToolSchemaType? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.RetrievalObject? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponse? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseChoice>? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseChoice? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessage? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseUsage? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseUsagePromptTokensDetails? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectResponse? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseMessageToolCall>? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessageToolCall? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessageToolCallFunction? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3Request? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Model? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Quality? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.OneOf<string, byte[]>>? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<string, byte[]>? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Size? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VideoCommonRequest? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequest? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Model? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Style? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1AspectRatio? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Size? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1MovementAmplitude? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequest? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1Model? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image?, global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image?>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1MovementAmplitude? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequest? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1Model? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd?, global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd?>? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1MovementAmplitude? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequest? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1Model? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1AspectRatio? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1Size? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncResponse? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncCreateImageRequest? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncCreateImageRequestModel? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncCreateImageRequestQuality? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncVideoGenerationResponse? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AsyncVideoGenerationResponseVideoResultItem>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncVideoGenerationResponseVideoResultItem? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncImageGenerationResponse? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AsyncImageGenerationResponseImageResultItem>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncImageGenerationResponseImageResultItem? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VideoResponse? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateImageRequest? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateImageRequestModel? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateImageRequestQuality? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ImageGenerationResponse? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseDataItem>? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ImageGenerationResponseDataItem? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseContentFilterItem>? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ImageGenerationResponseContentFilterItem? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ImageGenerationResponseContentFilterItemRole? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AudioTranscriptionRequest? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AudioTranscriptionRequestModel? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AudioTranscriptionResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AudioTranscriptionStreamResponse? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequest? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestModel? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageUserMessage? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageUserMessageRole? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageSystemMessage? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageSystemMessageRole? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageAssistantMessage? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageAssistantMessageRole? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerResponse? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerResponseUsage? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchRequest? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchRequestSearchEngine? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchRequestSearchRecencyFilter? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchResponse? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequest? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestAgentId? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessage>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessage? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageRole? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessageContentItem>? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageContentItem? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageContentItemType? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariables? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesSourceLang? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesTargetLang? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategy? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfig? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigGeneral? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCot? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponse? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentResponseChoice>? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoice? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoiceMessages? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoiceMessagesContent? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponseUsage? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequest? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestAgentId? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.SpecialEffectsVideosAgentRequestMessage>? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessage? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageRole? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemTextType? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariables? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariablesTemplate? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponse? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponseVariant1? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentError? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentErrorError? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequest? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestAgentId? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessage>? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessage? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageRole? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessageContentItem>? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageContentItem? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageContentItemType? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponse? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoice>? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoice? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItem? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItemObject? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseError? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultRequest? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequest? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariables? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponse? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoice>? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoice? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseError? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultResponse? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoice>? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoice? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItem>? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoiceMessageItem? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingRequest? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingRequestModel? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingResponse? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutDetail? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.DataInfo? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingResponseUsage? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingResponseUsagePromptTokensDetails? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutDetailLabel? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.PageInfo>? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.PageInfo? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.BadRequestData? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.UnauthorizedData? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.NotFoundData? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.Error? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequest, global::ZAI.ChatCompletionVisionRequest>? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4FilesRequest? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4FilesRequestPurpose? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.TranslationAgentRequest, global::ZAI.SpecialEffectsVideosAgentRequest, global::ZAI.GlmSlideAgentRequest>? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4ChatCompletionsAcceptLanguage? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4VideosGenerationsAcceptLanguage? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GetPaasV4AsyncResultAcceptLanguage? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4WebSearchAcceptLanguage? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateAgentsAcceptLanguage? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateAgentsAsyncResultAcceptLanguage? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateAgentsConversationAcceptLanguage? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.AsyncVideoGenerationResponse, global::ZAI.AsyncImageGenerationResponse>? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4FilesResponse? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.Error, global::ZAI.SpecialEffectsVideosAgentError>? Type283 { get; set; }

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