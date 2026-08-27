
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
        public global::ZAI.VisionMultimodalContentItemFileId? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFileIdType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VisionMultimodalContentItemFileIdFile? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatThinkingType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchToolSchemaType? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObject? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectSearchEngine? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectSearchRecencyFilter? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectContentSize? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectResultSequence? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.FunctionToolSchemaType? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.FunctionObject? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.FunctionParameters? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.RetrievalToolSchemaType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.RetrievalObject? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponse? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseChoice>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseChoice? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessage? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseUsage? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseUsagePromptTokensDetails? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.WebSearchObjectResponse>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchObjectResponse? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ChatCompletionResponseMessageToolCall>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessageToolCall? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ChatCompletionResponseMessageToolCallFunction? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3Request? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Model? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Quality? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.OneOf<string, byte[]>>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<string, byte[]>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CogVideoX3RequestVariant1Size? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VideoCommonRequest? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduText2VideoRequest? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Model? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Style? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1AspectRatio? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1Size? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduText2VideoRequestVariant1MovementAmplitude? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduImage2VideoRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1Model? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image?, global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image?>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1SizeViduq1Image? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1SizeViduq2Image? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduImage2VideoRequestVariant1MovementAmplitude? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequest? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1Model? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd?, global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd?>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1SizeViduq1StartEnd? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1SizeVidu2StartEnd? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduFrames2VideoRequestVariant1MovementAmplitude? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduReference2VideoRequest? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1Model? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1AspectRatio? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1Size? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ViduReference2VideoRequestVariant1MovementAmplitude? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncCreateImageRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncCreateImageRequestModel? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncCreateImageRequestQuality? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncVideoGenerationResponse? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AsyncVideoGenerationResponseVideoResultItem>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncVideoGenerationResponseVideoResultItem? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncImageGenerationResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.AsyncImageGenerationResponseImageResultItem>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AsyncImageGenerationResponseImageResultItem? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.VideoResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateImageRequest? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateImageRequestModel? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateImageRequestQuality? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ImageGenerationResponse? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseDataItem>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ImageGenerationResponseDataItem? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.ImageGenerationResponseContentFilterItem>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ImageGenerationResponseContentFilterItem? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.ImageGenerationResponseContentFilterItemRole? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AudioTranscriptionRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AudioTranscriptionRequestModel? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AudioTranscriptionResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.AudioTranscriptionStreamResponse? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestModel? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageUserMessage? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageUserMessageRole? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageSystemMessage? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageSystemMessageRole? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageAssistantMessage? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerRequestMessageAssistantMessageRole? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TokenizerResponseUsage? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchRequestSearchEngine? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchRequestSearchRecencyFilter? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.WebSearchResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequest? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestAgentId? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessage>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessage? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageRole? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentRequestMessageContentItem>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageContentItem? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestMessageContentItemType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariables? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesSourceLang? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesTargetLang? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategy? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfig? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigGeneral? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCot? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfigCotReasonLang? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.TranslationAgentResponseChoice>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoice? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoiceMessages? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponseChoiceMessagesContent? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.TranslationAgentResponseUsage? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequest? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestAgentId? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.SpecialEffectsVideosAgentRequestMessage>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessage? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageRole? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemText? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemTextType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrl? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestMessageContentItemImageUrlType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariables? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentRequestCustomVariablesTemplate? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentResponseVariant1? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentError? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.SpecialEffectsVideosAgentErrorError? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestAgentId? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessage>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessage? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageRole? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentRequestMessageContentItem>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageContentItem? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentRequestMessageContentItemType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoice>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoice? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItem>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItem? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItem? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseChoiceMessageItemContentItemObject? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentResponseError? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequest? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariables? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationRequestCustomVariablesPage? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoice>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoice? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItem? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseChoiceMessageItemContentItem? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GlmSlideAgentConversationResponseError? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultResponse? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoice>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoice? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItem>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoiceMessageItem? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CommonAgentResultResponseChoiceMessageItemContentItem? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingRequest? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingRequestModel? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.LayoutDetail>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutDetail? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.DataInfo? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingResponseUsage? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutParsingResponseUsagePromptTokensDetails? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.LayoutDetailLabel? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ZAI.PageInfo>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.PageInfo? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.BadRequestData? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.UnauthorizedData? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.NotFoundData? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.Error? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.ChatCompletionTextRequest, global::ZAI.ChatCompletionVisionRequest>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4FilesRequest? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4FilesRequestPurpose? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.TranslationAgentRequest, global::ZAI.SpecialEffectsVideosAgentRequest, global::ZAI.GlmSlideAgentRequest>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4ChatCompletionsAcceptLanguage? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4VideosGenerationsAcceptLanguage? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.GetPaasV4AsyncResultAcceptLanguage? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4WebSearchAcceptLanguage? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateAgentsAcceptLanguage? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateAgentsAsyncResultAcceptLanguage? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreateAgentsConversationAcceptLanguage? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.AsyncVideoGenerationResponse, global::ZAI.AsyncImageGenerationResponse>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.CreatePaasV4FilesResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.TranslationAgentResponse, global::ZAI.SpecialEffectsVideosAgentResponse?, global::ZAI.GlmSlideAgentResponse>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ZAI.OneOf<global::ZAI.Error, global::ZAI.SpecialEffectsVideosAgentError>? Type286 { get; set; }

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