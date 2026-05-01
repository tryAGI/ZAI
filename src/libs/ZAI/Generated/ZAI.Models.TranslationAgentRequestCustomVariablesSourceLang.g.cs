
#nullable enable

namespace ZAI
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
    public enum TranslationAgentRequestCustomVariablesSourceLang
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
        /// Arabic
        /// </summary>
        Ar,
        /// <summary>
        /// `auto`):
        /// </summary>
        Auto,
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
        /// `auto`):
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
        /// `auto`):
        /// </summary>
        Es,
        /// <summary>
        /// Auto Detect
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
        /// `auto`):
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
        /// Simplified Chinese
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
    public static class TranslationAgentRequestCustomVariablesSourceLangExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationAgentRequestCustomVariablesSourceLang value)
        {
            return value switch
            {
                TranslationAgentRequestCustomVariablesSourceLang.Ipa => "IPA",
                TranslationAgentRequestCustomVariablesSourceLang.Pinyin => "Pinyin",
                TranslationAgentRequestCustomVariablesSourceLang.Ar => "ar",
                TranslationAgentRequestCustomVariablesSourceLang.Auto => "auto",
                TranslationAgentRequestCustomVariablesSourceLang.Bg => "bg",
                TranslationAgentRequestCustomVariablesSourceLang.Cs => "cs",
                TranslationAgentRequestCustomVariablesSourceLang.Da => "da",
                TranslationAgentRequestCustomVariablesSourceLang.De => "de",
                TranslationAgentRequestCustomVariablesSourceLang.El => "el",
                TranslationAgentRequestCustomVariablesSourceLang.En => "en",
                TranslationAgentRequestCustomVariablesSourceLang.Es => "es",
                TranslationAgentRequestCustomVariablesSourceLang.Et => "et",
                TranslationAgentRequestCustomVariablesSourceLang.Fi => "fi",
                TranslationAgentRequestCustomVariablesSourceLang.Fr => "fr",
                TranslationAgentRequestCustomVariablesSourceLang.Hi => "hi",
                TranslationAgentRequestCustomVariablesSourceLang.Hu => "hu",
                TranslationAgentRequestCustomVariablesSourceLang.Id => "id",
                TranslationAgentRequestCustomVariablesSourceLang.It => "it",
                TranslationAgentRequestCustomVariablesSourceLang.Ja => "ja",
                TranslationAgentRequestCustomVariablesSourceLang.Ko => "ko",
                TranslationAgentRequestCustomVariablesSourceLang.Lt => "lt",
                TranslationAgentRequestCustomVariablesSourceLang.Lv => "lv",
                TranslationAgentRequestCustomVariablesSourceLang.Ms => "ms",
                TranslationAgentRequestCustomVariablesSourceLang.My => "my",
                TranslationAgentRequestCustomVariablesSourceLang.Nl => "nl",
                TranslationAgentRequestCustomVariablesSourceLang.No => "no",
                TranslationAgentRequestCustomVariablesSourceLang.Pl => "pl",
                TranslationAgentRequestCustomVariablesSourceLang.Pt => "pt",
                TranslationAgentRequestCustomVariablesSourceLang.Ro => "ro",
                TranslationAgentRequestCustomVariablesSourceLang.Ru => "ru",
                TranslationAgentRequestCustomVariablesSourceLang.Sk => "sk",
                TranslationAgentRequestCustomVariablesSourceLang.Sl => "sl",
                TranslationAgentRequestCustomVariablesSourceLang.Sv => "sv",
                TranslationAgentRequestCustomVariablesSourceLang.Th => "th",
                TranslationAgentRequestCustomVariablesSourceLang.Tr => "tr",
                TranslationAgentRequestCustomVariablesSourceLang.Uk => "uk",
                TranslationAgentRequestCustomVariablesSourceLang.Vi => "vi",
                TranslationAgentRequestCustomVariablesSourceLang.Wyw => "wyw",
                TranslationAgentRequestCustomVariablesSourceLang.Yue => "yue",
                TranslationAgentRequestCustomVariablesSourceLang.ZhCn => "zh-CN",
                TranslationAgentRequestCustomVariablesSourceLang.ZhTw => "zh-TW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationAgentRequestCustomVariablesSourceLang? ToEnum(string value)
        {
            return value switch
            {
                "IPA" => TranslationAgentRequestCustomVariablesSourceLang.Ipa,
                "Pinyin" => TranslationAgentRequestCustomVariablesSourceLang.Pinyin,
                "ar" => TranslationAgentRequestCustomVariablesSourceLang.Ar,
                "auto" => TranslationAgentRequestCustomVariablesSourceLang.Auto,
                "bg" => TranslationAgentRequestCustomVariablesSourceLang.Bg,
                "cs" => TranslationAgentRequestCustomVariablesSourceLang.Cs,
                "da" => TranslationAgentRequestCustomVariablesSourceLang.Da,
                "de" => TranslationAgentRequestCustomVariablesSourceLang.De,
                "el" => TranslationAgentRequestCustomVariablesSourceLang.El,
                "en" => TranslationAgentRequestCustomVariablesSourceLang.En,
                "es" => TranslationAgentRequestCustomVariablesSourceLang.Es,
                "et" => TranslationAgentRequestCustomVariablesSourceLang.Et,
                "fi" => TranslationAgentRequestCustomVariablesSourceLang.Fi,
                "fr" => TranslationAgentRequestCustomVariablesSourceLang.Fr,
                "hi" => TranslationAgentRequestCustomVariablesSourceLang.Hi,
                "hu" => TranslationAgentRequestCustomVariablesSourceLang.Hu,
                "id" => TranslationAgentRequestCustomVariablesSourceLang.Id,
                "it" => TranslationAgentRequestCustomVariablesSourceLang.It,
                "ja" => TranslationAgentRequestCustomVariablesSourceLang.Ja,
                "ko" => TranslationAgentRequestCustomVariablesSourceLang.Ko,
                "lt" => TranslationAgentRequestCustomVariablesSourceLang.Lt,
                "lv" => TranslationAgentRequestCustomVariablesSourceLang.Lv,
                "ms" => TranslationAgentRequestCustomVariablesSourceLang.Ms,
                "my" => TranslationAgentRequestCustomVariablesSourceLang.My,
                "nl" => TranslationAgentRequestCustomVariablesSourceLang.Nl,
                "no" => TranslationAgentRequestCustomVariablesSourceLang.No,
                "pl" => TranslationAgentRequestCustomVariablesSourceLang.Pl,
                "pt" => TranslationAgentRequestCustomVariablesSourceLang.Pt,
                "ro" => TranslationAgentRequestCustomVariablesSourceLang.Ro,
                "ru" => TranslationAgentRequestCustomVariablesSourceLang.Ru,
                "sk" => TranslationAgentRequestCustomVariablesSourceLang.Sk,
                "sl" => TranslationAgentRequestCustomVariablesSourceLang.Sl,
                "sv" => TranslationAgentRequestCustomVariablesSourceLang.Sv,
                "th" => TranslationAgentRequestCustomVariablesSourceLang.Th,
                "tr" => TranslationAgentRequestCustomVariablesSourceLang.Tr,
                "uk" => TranslationAgentRequestCustomVariablesSourceLang.Uk,
                "vi" => TranslationAgentRequestCustomVariablesSourceLang.Vi,
                "wyw" => TranslationAgentRequestCustomVariablesSourceLang.Wyw,
                "yue" => TranslationAgentRequestCustomVariablesSourceLang.Yue,
                "zh-CN" => TranslationAgentRequestCustomVariablesSourceLang.ZhCn,
                "zh-TW" => TranslationAgentRequestCustomVariablesSourceLang.ZhTw,
                _ => null,
            };
        }
    }
}