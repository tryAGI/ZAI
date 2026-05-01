
#nullable enable

namespace ZAI
{
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
    public enum TranslationAgentRequestCustomVariablesTargetLang
    {
        /// <summary>
        /// International Phonetic Alphabet
        /// </summary>
        Ipa,
        /// <summary>
        /// Pinyin
        /// </summary>
        Pinyin,
        /// <summary>
        /// `zh-CN`):
        /// </summary>
        Ar,
        /// <summary>
        /// Bulgarian
        /// </summary>
        Bg,
        /// <summary>
        /// Czech
        /// </summary>
        Cs,
        /// <summary>
        /// Danish
        /// </summary>
        Da,
        /// <summary>
        /// `zh-CN`):
        /// </summary>
        De,
        /// <summary>
        /// Greek
        /// </summary>
        El,
        /// <summary>
        /// English
        /// </summary>
        En,
        /// <summary>
        /// English (British)
        /// </summary>
        EnGb,
        /// <summary>
        /// English (American)
        /// </summary>
        EnUs,
        /// <summary>
        /// Simplified Chinese
        /// </summary>
        Es,
        /// <summary>
        /// `zh-CN`):
        /// </summary>
        Et,
        /// <summary>
        /// Simplified Chinese
        /// </summary>
        Fi,
        /// <summary>
        /// French
        /// </summary>
        Fr,
        /// <summary>
        /// Simplified Chinese
        /// </summary>
        Hi,
        /// <summary>
        /// Hungarian
        /// </summary>
        Hu,
        /// <summary>
        /// Indonesian
        /// </summary>
        Id,
        /// <summary>
        /// Traditional Chinese
        /// </summary>
        It,
        /// <summary>
        /// Japanese
        /// </summary>
        Ja,
        /// <summary>
        /// Korean
        /// </summary>
        Ko,
        /// <summary>
        /// `zh-CN`):
        /// </summary>
        Lt,
        /// <summary>
        /// Latvian
        /// </summary>
        Lv,
        /// <summary>
        /// Malay
        /// </summary>
        Ms,
        /// <summary>
        /// Burmese
        /// </summary>
        My,
        /// <summary>
        /// Dutch
        /// </summary>
        Nl,
        /// <summary>
        /// Norwegian Bokmål
        /// </summary>
        No,
        /// <summary>
        /// Simplified Chinese
        /// </summary>
        Pl,
        /// <summary>
        /// Portuguese
        /// </summary>
        Pt,
        /// <summary>
        /// Romanian
        /// </summary>
        Ro,
        /// <summary>
        /// Russian
        /// </summary>
        Ru,
        /// <summary>
        /// Slovak
        /// </summary>
        Sk,
        /// <summary>
        /// Slovenian
        /// </summary>
        Sl,
        /// <summary>
        /// Swedish
        /// </summary>
        Sv,
        /// <summary>
        /// Lithuanian
        /// </summary>
        Th,
        /// <summary>
        /// Turkish
        /// </summary>
        Tr,
        /// <summary>
        /// Ukrainian
        /// </summary>
        Uk,
        /// <summary>
        /// Latvian
        /// </summary>
        Vi,
        /// <summary>
        /// Classical Chinese
        /// </summary>
        Wyw,
        /// <summary>
        /// Cantonese
        /// </summary>
        Yue,
        /// <summary>
        /// `zh-CN`):
        /// </summary>
        ZhCn,
        /// <summary>
        /// Traditional Chinese
        /// </summary>
        ZhTw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationAgentRequestCustomVariablesTargetLangExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationAgentRequestCustomVariablesTargetLang value)
        {
            return value switch
            {
                TranslationAgentRequestCustomVariablesTargetLang.Ipa => "IPA",
                TranslationAgentRequestCustomVariablesTargetLang.Pinyin => "Pinyin",
                TranslationAgentRequestCustomVariablesTargetLang.Ar => "ar",
                TranslationAgentRequestCustomVariablesTargetLang.Bg => "bg",
                TranslationAgentRequestCustomVariablesTargetLang.Cs => "cs",
                TranslationAgentRequestCustomVariablesTargetLang.Da => "da",
                TranslationAgentRequestCustomVariablesTargetLang.De => "de",
                TranslationAgentRequestCustomVariablesTargetLang.El => "el",
                TranslationAgentRequestCustomVariablesTargetLang.En => "en",
                TranslationAgentRequestCustomVariablesTargetLang.EnGb => "en-GB",
                TranslationAgentRequestCustomVariablesTargetLang.EnUs => "en-US",
                TranslationAgentRequestCustomVariablesTargetLang.Es => "es",
                TranslationAgentRequestCustomVariablesTargetLang.Et => "et",
                TranslationAgentRequestCustomVariablesTargetLang.Fi => "fi",
                TranslationAgentRequestCustomVariablesTargetLang.Fr => "fr",
                TranslationAgentRequestCustomVariablesTargetLang.Hi => "hi",
                TranslationAgentRequestCustomVariablesTargetLang.Hu => "hu",
                TranslationAgentRequestCustomVariablesTargetLang.Id => "id",
                TranslationAgentRequestCustomVariablesTargetLang.It => "it",
                TranslationAgentRequestCustomVariablesTargetLang.Ja => "ja",
                TranslationAgentRequestCustomVariablesTargetLang.Ko => "ko",
                TranslationAgentRequestCustomVariablesTargetLang.Lt => "lt",
                TranslationAgentRequestCustomVariablesTargetLang.Lv => "lv",
                TranslationAgentRequestCustomVariablesTargetLang.Ms => "ms",
                TranslationAgentRequestCustomVariablesTargetLang.My => "my",
                TranslationAgentRequestCustomVariablesTargetLang.Nl => "nl",
                TranslationAgentRequestCustomVariablesTargetLang.No => "no",
                TranslationAgentRequestCustomVariablesTargetLang.Pl => "pl",
                TranslationAgentRequestCustomVariablesTargetLang.Pt => "pt",
                TranslationAgentRequestCustomVariablesTargetLang.Ro => "ro",
                TranslationAgentRequestCustomVariablesTargetLang.Ru => "ru",
                TranslationAgentRequestCustomVariablesTargetLang.Sk => "sk",
                TranslationAgentRequestCustomVariablesTargetLang.Sl => "sl",
                TranslationAgentRequestCustomVariablesTargetLang.Sv => "sv",
                TranslationAgentRequestCustomVariablesTargetLang.Th => "th",
                TranslationAgentRequestCustomVariablesTargetLang.Tr => "tr",
                TranslationAgentRequestCustomVariablesTargetLang.Uk => "uk",
                TranslationAgentRequestCustomVariablesTargetLang.Vi => "vi",
                TranslationAgentRequestCustomVariablesTargetLang.Wyw => "wyw",
                TranslationAgentRequestCustomVariablesTargetLang.Yue => "yue",
                TranslationAgentRequestCustomVariablesTargetLang.ZhCn => "zh-CN",
                TranslationAgentRequestCustomVariablesTargetLang.ZhTw => "zh-TW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationAgentRequestCustomVariablesTargetLang? ToEnum(string value)
        {
            return value switch
            {
                "IPA" => TranslationAgentRequestCustomVariablesTargetLang.Ipa,
                "Pinyin" => TranslationAgentRequestCustomVariablesTargetLang.Pinyin,
                "ar" => TranslationAgentRequestCustomVariablesTargetLang.Ar,
                "bg" => TranslationAgentRequestCustomVariablesTargetLang.Bg,
                "cs" => TranslationAgentRequestCustomVariablesTargetLang.Cs,
                "da" => TranslationAgentRequestCustomVariablesTargetLang.Da,
                "de" => TranslationAgentRequestCustomVariablesTargetLang.De,
                "el" => TranslationAgentRequestCustomVariablesTargetLang.El,
                "en" => TranslationAgentRequestCustomVariablesTargetLang.En,
                "en-GB" => TranslationAgentRequestCustomVariablesTargetLang.EnGb,
                "en-US" => TranslationAgentRequestCustomVariablesTargetLang.EnUs,
                "es" => TranslationAgentRequestCustomVariablesTargetLang.Es,
                "et" => TranslationAgentRequestCustomVariablesTargetLang.Et,
                "fi" => TranslationAgentRequestCustomVariablesTargetLang.Fi,
                "fr" => TranslationAgentRequestCustomVariablesTargetLang.Fr,
                "hi" => TranslationAgentRequestCustomVariablesTargetLang.Hi,
                "hu" => TranslationAgentRequestCustomVariablesTargetLang.Hu,
                "id" => TranslationAgentRequestCustomVariablesTargetLang.Id,
                "it" => TranslationAgentRequestCustomVariablesTargetLang.It,
                "ja" => TranslationAgentRequestCustomVariablesTargetLang.Ja,
                "ko" => TranslationAgentRequestCustomVariablesTargetLang.Ko,
                "lt" => TranslationAgentRequestCustomVariablesTargetLang.Lt,
                "lv" => TranslationAgentRequestCustomVariablesTargetLang.Lv,
                "ms" => TranslationAgentRequestCustomVariablesTargetLang.Ms,
                "my" => TranslationAgentRequestCustomVariablesTargetLang.My,
                "nl" => TranslationAgentRequestCustomVariablesTargetLang.Nl,
                "no" => TranslationAgentRequestCustomVariablesTargetLang.No,
                "pl" => TranslationAgentRequestCustomVariablesTargetLang.Pl,
                "pt" => TranslationAgentRequestCustomVariablesTargetLang.Pt,
                "ro" => TranslationAgentRequestCustomVariablesTargetLang.Ro,
                "ru" => TranslationAgentRequestCustomVariablesTargetLang.Ru,
                "sk" => TranslationAgentRequestCustomVariablesTargetLang.Sk,
                "sl" => TranslationAgentRequestCustomVariablesTargetLang.Sl,
                "sv" => TranslationAgentRequestCustomVariablesTargetLang.Sv,
                "th" => TranslationAgentRequestCustomVariablesTargetLang.Th,
                "tr" => TranslationAgentRequestCustomVariablesTargetLang.Tr,
                "uk" => TranslationAgentRequestCustomVariablesTargetLang.Uk,
                "vi" => TranslationAgentRequestCustomVariablesTargetLang.Vi,
                "wyw" => TranslationAgentRequestCustomVariablesTargetLang.Wyw,
                "yue" => TranslationAgentRequestCustomVariablesTargetLang.Yue,
                "zh-CN" => TranslationAgentRequestCustomVariablesTargetLang.ZhCn,
                "zh-TW" => TranslationAgentRequestCustomVariablesTargetLang.ZhTw,
                _ => null,
            };
        }
    }
}