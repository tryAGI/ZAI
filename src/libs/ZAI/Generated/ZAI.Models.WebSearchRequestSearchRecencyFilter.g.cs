
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Search for webpages within a specified time range.<br/>
    /// Default is `noLimit`<br/>
    /// Fillable values:<br/>
    /// `oneDay`: within one day<br/>
    /// `oneWeek`: within one week<br/>
    /// `oneMonth`: within one month<br/>
    /// `oneYear`: within one year<br/>
    /// `noLimit`: no limit (default)<br/>
    /// Supported search engines: <br/>
    /// `search_pro_jina`
    /// </summary>
    public enum WebSearchRequestSearchRecencyFilter
    {
        /// <summary>
        /// no limit (default)
        /// </summary>
        NoLimit,
        /// <summary>
        /// within one day
        /// </summary>
        OneDay,
        /// <summary>
        /// within one month
        /// </summary>
        OneMonth,
        /// <summary>
        /// within one week
        /// </summary>
        OneWeek,
        /// <summary>
        /// within one year
        /// </summary>
        OneYear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestSearchRecencyFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestSearchRecencyFilter value)
        {
            return value switch
            {
                WebSearchRequestSearchRecencyFilter.NoLimit => "noLimit",
                WebSearchRequestSearchRecencyFilter.OneDay => "oneDay",
                WebSearchRequestSearchRecencyFilter.OneMonth => "oneMonth",
                WebSearchRequestSearchRecencyFilter.OneWeek => "oneWeek",
                WebSearchRequestSearchRecencyFilter.OneYear => "oneYear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestSearchRecencyFilter? ToEnum(string value)
        {
            return value switch
            {
                "noLimit" => WebSearchRequestSearchRecencyFilter.NoLimit,
                "oneDay" => WebSearchRequestSearchRecencyFilter.OneDay,
                "oneMonth" => WebSearchRequestSearchRecencyFilter.OneMonth,
                "oneWeek" => WebSearchRequestSearchRecencyFilter.OneWeek,
                "oneYear" => WebSearchRequestSearchRecencyFilter.OneYear,
                _ => null,
            };
        }
    }
}