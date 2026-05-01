
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Limits search to a specific time range.<br/>
    /// Default is `noLimit`<br/>
    /// Values:<br/>
    /// `oneDay`, within a day<br/>
    /// `oneWeek`, within a week<br/>
    /// `oneMonth`, within a month<br/>
    /// `oneYear`, within a year<br/>
    /// `noLimit`, no limit (default)<br/>
    /// Supported engines: `search_pro_jina`
    /// </summary>
    public enum WebSearchObjectSearchRecencyFilter
    {
        /// <summary>
        /// 
        /// </summary>
        NoLimit,
        /// <summary>
        /// 
        /// </summary>
        OneDay,
        /// <summary>
        /// 
        /// </summary>
        OneMonth,
        /// <summary>
        /// 
        /// </summary>
        OneWeek,
        /// <summary>
        /// 
        /// </summary>
        OneYear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchObjectSearchRecencyFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchObjectSearchRecencyFilter value)
        {
            return value switch
            {
                WebSearchObjectSearchRecencyFilter.NoLimit => "noLimit",
                WebSearchObjectSearchRecencyFilter.OneDay => "oneDay",
                WebSearchObjectSearchRecencyFilter.OneMonth => "oneMonth",
                WebSearchObjectSearchRecencyFilter.OneWeek => "oneWeek",
                WebSearchObjectSearchRecencyFilter.OneYear => "oneYear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchObjectSearchRecencyFilter? ToEnum(string value)
        {
            return value switch
            {
                "noLimit" => WebSearchObjectSearchRecencyFilter.NoLimit,
                "oneDay" => WebSearchObjectSearchRecencyFilter.OneDay,
                "oneMonth" => WebSearchObjectSearchRecencyFilter.OneMonth,
                "oneWeek" => WebSearchObjectSearchRecencyFilter.OneWeek,
                "oneYear" => WebSearchObjectSearchRecencyFilter.OneYear,
                _ => null,
            };
        }
    }
}