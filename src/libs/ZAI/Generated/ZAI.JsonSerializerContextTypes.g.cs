
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
        public float? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AnyOf<global::ZAI.FunctionToolSchema, global::ZAI.RetrievalToolSchema, global::ZAI.WebSearchToolSchema>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.FunctionToolSchema? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.RetrievalToolSchema? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchToolSchema? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestToolChoice? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestResponseFormat? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionTextRequestResponseFormatType? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequest? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestModel? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageUserMessage? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageUserMessageRole? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>, string>? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.VisionMultimodalContentItem>? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItem? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageSystemMessage? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageSystemMessageRole? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageAssistantMessage? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestMessageAssistantMessageRole? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.FunctionToolSchema>? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionVisionRequestToolChoice? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItem? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemText? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemTextType? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemImage? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemImageType? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemImageImageUrl? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemAudio? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemAudioType? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemAudioInputAudio? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemAudioInputAudioFormat? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemVideo? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemVideoType? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemVideoVideoUrl? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemFile? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemFileType? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.MultimodalContentItemFileFileUrl? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemText? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemTextType? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImage? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImageType? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemImageImageUrl? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideo? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideoType? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemVideoVideoUrl? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFile? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFileType? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFileFileUrl? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatThinkingType? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchToolSchemaType? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObject? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectSearchEngine? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectSearchRecencyFilter? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectContentSize? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectResultSequence? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.FunctionToolSchemaType? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.FunctionObject? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.FunctionParameters? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.RetrievalToolSchemaType? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.RetrievalObject? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponse? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseChoice>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseChoice? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessage? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseUsage? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseUsagePromptTokensDetails? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchObjectResponse? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseMessageToolCall>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessageToolCall? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessageToolCallFunction? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3Request? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Model? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Quality? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.OneOf<string, byte[]>>? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<string, byte[]>? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Size? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VideoCommonRequest? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequest? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Model? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Style? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1AspectRatio? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Size? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1MovementAmplitude? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequest? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1Model? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image?, global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image?>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1MovementAmplitude? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequest? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1Model? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd?, global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd?>? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1MovementAmplitude? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequest? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1Model? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1AspectRatio? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1Size? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncResponse? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncCreateImageRequest? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncCreateImageRequestModel? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncCreateImageRequestQuality? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncVideoGenerationResponse? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AsyncVideoGenerationResponseVideoResultItem>? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncVideoGenerationResponseVideoResultItem? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncImageGenerationResponse? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AsyncImageGenerationResponseImageResultItem>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AsyncImageGenerationResponseImageResultItem? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.VideoResponse? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateImageRequest? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateImageRequestModel? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateImageRequestQuality? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ImageGenerationResponse? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseDataItem>? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ImageGenerationResponseDataItem? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseContentFilterItem>? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ImageGenerationResponseContentFilterItem? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.ImageGenerationResponseContentFilterItemRole? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AudioTranscriptionRequest? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AudioTranscriptionRequestModel? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AudioTranscriptionResponse? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.AudioTranscriptionStreamResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequest? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestModel? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageUserMessage? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageUserMessageRole? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageSystemMessage? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageSystemMessageRole? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageAssistantMessage? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerRequestMessageAssistantMessageRole? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerResponse? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TokenizerResponseUsage? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchRequest? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchRequestSearchEngine? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchRequestSearchRecencyFilter? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.WebSearchResponse? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequest? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestAgentId? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessage>? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessage? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageRole? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessageContentItem>? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageContentItem? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageContentItemType? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariables? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesSourceLang? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesTargetLang? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategy? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfig? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigGeneral? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCot? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponse? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentResponseChoice>? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoice? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoiceMessages? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoiceMessagesContent? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.TranslationAgentResponseUsage? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequest? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestAgentId? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.SpecialEffectsVideosAgentRequestMessage>? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessage? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageRole? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemTextType? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariables? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariablesTemplate? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponse? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponseVariant1? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentError? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentErrorError? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequest? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestAgentId? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessage>? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessage? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageRole? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessageContentItem>? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageContentItem? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageContentItemType? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponse? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoice>? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoice? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItem? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItemObject? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseError? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultRequest? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequest? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariables? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponse? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoice>? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoice? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseError? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultResponse? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoice>? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoice? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItem>? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoiceMessageItem? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingRequest? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingRequestModel? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingResponse? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>>? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutDetail? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.DataInfo? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingResponseUsage? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutParsingResponseUsagePromptTokensDetails? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.LayoutDetailLabel? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.PageInfo>? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.PageInfo? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.BadRequestData? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.UnauthorizedData? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.NotFoundData? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.Error? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequest, global::ZAI.ChatCompletionVisionRequest>? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4FilesRequest? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4FilesRequestPurpose? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.TranslationAgentRequest, global::ZAI.SpecialEffectsVideosAgentRequest, global::ZAI.GlmSlideAgentRequest>? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4ChatCompletionsAcceptLanguage? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4VideosGenerationsAcceptLanguage? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.GetPaasV4AsyncResultAcceptLanguage? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4WebSearchAcceptLanguage? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateAgentsAcceptLanguage? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateAgentsAsyncResultAcceptLanguage? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreateAgentsConversationAcceptLanguage? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.AsyncVideoGenerationResponse, global::ZAI.AsyncImageGenerationResponse>? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.CreatePaasV4FilesResponse? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.Error, global::ZAI.SpecialEffectsVideosAgentError>? Type281 { get; set; }

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