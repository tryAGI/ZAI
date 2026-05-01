
#nullable enable

namespace ZAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationAgentRequestCustomVariables
    {
        /// <summary>
        /// Supported language codes (default: `auto`):<br/>
        /// - `auto`: Auto Detect<br/>
        /// - `zh-CN`: Simplified Chinese<br/>
        /// - `zh-TW`: Traditional Chinese<br/>
        /// - `wyw`: Classical Chinese<br/>
        /// - `yue`: Cantonese<br/>
        /// - `en`: English<br/>
        /// - `ja`: Japanese<br/>
        /// - `ko`: Korean<br/>
        /// - `fr`: French<br/>
        /// - `de`: German<br/>
        /// - `es`: Spanish<br/>
        /// - `ru`: Russian<br/>
        /// - `pt`: Portuguese<br/>
        /// - `it`: Italian<br/>
        /// - `ar`: Arabic<br/>
        /// - `hi`: Hindi<br/>
        /// - `bg`: Bulgarian<br/>
        /// - `cs`: Czech<br/>
        /// - `da`: Danish<br/>
        /// - `el`: Greek<br/>
        /// - `et`: Estonian<br/>
        /// - `fi`: Finnish<br/>
        /// - `hu`: Hungarian<br/>
        /// - `id`: Indonesian<br/>
        /// - `lt`: Lithuanian<br/>
        /// - `lv`: Latvian<br/>
        /// - `nl`: Dutch<br/>
        /// - `no`: Norwegian Bokmål<br/>
        /// - `pl`: Polish<br/>
        /// - `ro`: Romanian<br/>
        /// - `sk`: Slovak<br/>
        /// - `sl`: Slovenian<br/>
        /// - `sv`: Swedish<br/>
        /// - `th`: Thai<br/>
        /// - `tr`: Turkish<br/>
        /// - `uk`: Ukrainian<br/>
        /// - `vi`: Vietnamese<br/>
        /// - `my`: Burmese<br/>
        /// - `ms`: Malay<br/>
        /// - `Pinyin`: Pinyin<br/>
        /// - `IPA`: International Phonetic Alphabet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesSourceLangJsonConverter))]
        public global::ZAI.TranslationAgentRequestCustomVariablesSourceLang? SourceLang { get; set; }

        /// <summary>
        /// Target language code (default: `zh-CN`):<br/>
        /// - `zh-CN`: Simplified Chinese<br/>
        /// - `zh-TW`: Traditional Chinese<br/>
        /// - `wyw`: Classical Chinese<br/>
        /// - `yue`: Cantonese<br/>
        /// - `en`: English<br/>
        /// - `en-GB`: English (British)<br/>
        /// - `en-US`: English (American)<br/>
        /// - `ja`: Japanese<br/>
        /// - `ko`: Korean<br/>
        /// - `fr`: French<br/>
        /// - `de`: German<br/>
        /// - `es`: Spanish<br/>
        /// - `ru`: Russian<br/>
        /// - `pt`: Portuguese<br/>
        /// - `it`: Italian<br/>
        /// - `ar`: Arabic<br/>
        /// - `hi`: Hindi<br/>
        /// - `bg`: Bulgarian<br/>
        /// - `cs`: Czech<br/>
        /// - `da`: Danish<br/>
        /// - `el`: Greek<br/>
        /// - `et`: Estonian<br/>
        /// - `fi`: Finnish<br/>
        /// - `hu`: Hungarian<br/>
        /// - `id`: Indonesian<br/>
        /// - `lt`: Lithuanian<br/>
        /// - `lv`: Latvian<br/>
        /// - `nl`: Dutch<br/>
        /// - `no`: Norwegian Bokmål<br/>
        /// - `pl`: Polish<br/>
        /// - `ro`: Romanian<br/>
        /// - `sk`: Slovak<br/>
        /// - `sl`: Slovenian<br/>
        /// - `sv`: Swedish<br/>
        /// - `th`: Thai<br/>
        /// - `tr`: Turkish<br/>
        /// - `uk`: Ukrainian<br/>
        /// - `vi`: Vietnamese<br/>
        /// - `my`: Burmese<br/>
        /// - `ms`: Malay<br/>
        /// - `Pinyin`: Pinyin<br/>
        /// - `IPA`: International Phonetic Alphabet<br/>
        /// .
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesTargetLangJsonConverter))]
        public global::ZAI.TranslationAgentRequestCustomVariablesTargetLang? TargetLang { get; set; }

        /// <summary>
        /// Glossary ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary")]
        public string? Glossary { get; set; }

        /// <summary>
        /// Translation strategy (default: `general`)，Optional:<br/>
        /// - `general`: General Translation<br/>
        /// - `paraphrase`: Paraphrase Translation<br/>
        /// - `two_step`: Two-Step Translation<br/>
        /// - `three_step`: Three-Stage Translation<br/>
        /// - `reflection`: Reflection Translation; cot: COT Translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ZAI.JsonConverters.TranslationAgentRequestCustomVariablesStrategyJsonConverter))]
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategy? Strategy { get; set; }

        /// <summary>
        /// Strategy parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy_config")]
        public global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfig? StrategyConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestCustomVariables" /> class.
        /// </summary>
        /// <param name="sourceLang">
        /// Supported language codes (default: `auto`):<br/>
        /// - `auto`: Auto Detect<br/>
        /// - `zh-CN`: Simplified Chinese<br/>
        /// - `zh-TW`: Traditional Chinese<br/>
        /// - `wyw`: Classical Chinese<br/>
        /// - `yue`: Cantonese<br/>
        /// - `en`: English<br/>
        /// - `ja`: Japanese<br/>
        /// - `ko`: Korean<br/>
        /// - `fr`: French<br/>
        /// - `de`: German<br/>
        /// - `es`: Spanish<br/>
        /// - `ru`: Russian<br/>
        /// - `pt`: Portuguese<br/>
        /// - `it`: Italian<br/>
        /// - `ar`: Arabic<br/>
        /// - `hi`: Hindi<br/>
        /// - `bg`: Bulgarian<br/>
        /// - `cs`: Czech<br/>
        /// - `da`: Danish<br/>
        /// - `el`: Greek<br/>
        /// - `et`: Estonian<br/>
        /// - `fi`: Finnish<br/>
        /// - `hu`: Hungarian<br/>
        /// - `id`: Indonesian<br/>
        /// - `lt`: Lithuanian<br/>
        /// - `lv`: Latvian<br/>
        /// - `nl`: Dutch<br/>
        /// - `no`: Norwegian Bokmål<br/>
        /// - `pl`: Polish<br/>
        /// - `ro`: Romanian<br/>
        /// - `sk`: Slovak<br/>
        /// - `sl`: Slovenian<br/>
        /// - `sv`: Swedish<br/>
        /// - `th`: Thai<br/>
        /// - `tr`: Turkish<br/>
        /// - `uk`: Ukrainian<br/>
        /// - `vi`: Vietnamese<br/>
        /// - `my`: Burmese<br/>
        /// - `ms`: Malay<br/>
        /// - `Pinyin`: Pinyin<br/>
        /// - `IPA`: International Phonetic Alphabet
        /// </param>
        /// <param name="targetLang">
        /// Target language code (default: `zh-CN`):<br/>
        /// - `zh-CN`: Simplified Chinese<br/>
        /// - `zh-TW`: Traditional Chinese<br/>
        /// - `wyw`: Classical Chinese<br/>
        /// - `yue`: Cantonese<br/>
        /// - `en`: English<br/>
        /// - `en-GB`: English (British)<br/>
        /// - `en-US`: English (American)<br/>
        /// - `ja`: Japanese<br/>
        /// - `ko`: Korean<br/>
        /// - `fr`: French<br/>
        /// - `de`: German<br/>
        /// - `es`: Spanish<br/>
        /// - `ru`: Russian<br/>
        /// - `pt`: Portuguese<br/>
        /// - `it`: Italian<br/>
        /// - `ar`: Arabic<br/>
        /// - `hi`: Hindi<br/>
        /// - `bg`: Bulgarian<br/>
        /// - `cs`: Czech<br/>
        /// - `da`: Danish<br/>
        /// - `el`: Greek<br/>
        /// - `et`: Estonian<br/>
        /// - `fi`: Finnish<br/>
        /// - `hu`: Hungarian<br/>
        /// - `id`: Indonesian<br/>
        /// - `lt`: Lithuanian<br/>
        /// - `lv`: Latvian<br/>
        /// - `nl`: Dutch<br/>
        /// - `no`: Norwegian Bokmål<br/>
        /// - `pl`: Polish<br/>
        /// - `ro`: Romanian<br/>
        /// - `sk`: Slovak<br/>
        /// - `sl`: Slovenian<br/>
        /// - `sv`: Swedish<br/>
        /// - `th`: Thai<br/>
        /// - `tr`: Turkish<br/>
        /// - `uk`: Ukrainian<br/>
        /// - `vi`: Vietnamese<br/>
        /// - `my`: Burmese<br/>
        /// - `ms`: Malay<br/>
        /// - `Pinyin`: Pinyin<br/>
        /// - `IPA`: International Phonetic Alphabet<br/>
        /// .
        /// </param>
        /// <param name="glossary">
        /// Glossary ID.
        /// </param>
        /// <param name="strategy">
        /// Translation strategy (default: `general`)，Optional:<br/>
        /// - `general`: General Translation<br/>
        /// - `paraphrase`: Paraphrase Translation<br/>
        /// - `two_step`: Two-Step Translation<br/>
        /// - `three_step`: Three-Stage Translation<br/>
        /// - `reflection`: Reflection Translation; cot: COT Translation
        /// </param>
        /// <param name="strategyConfig">
        /// Strategy parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationAgentRequestCustomVariables(
            global::ZAI.TranslationAgentRequestCustomVariablesSourceLang? sourceLang,
            global::ZAI.TranslationAgentRequestCustomVariablesTargetLang? targetLang,
            string? glossary,
            global::ZAI.TranslationAgentRequestCustomVariablesStrategy? strategy,
            global::ZAI.TranslationAgentRequestCustomVariablesStrategyConfig? strategyConfig)
        {
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.Glossary = glossary;
            this.Strategy = strategy;
            this.StrategyConfig = strategyConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationAgentRequestCustomVariables" /> class.
        /// </summary>
        public TranslationAgentRequestCustomVariables()
        {
        }
    }
}