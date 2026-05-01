
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Element type: image for images, text for text content, formula for inline formulas, table for tables<br/>
    /// Example: text
    /// </summary>
    public enum LayoutDetailLabel
    {
        /// <summary>
        /// image for images, text for text content, formula for inline formulas, table for tables
        /// </summary>
        Formula,
        /// <summary>
        /// image for images, text for text content, formula for inline formulas, table for tables
        /// </summary>
        Image,
        /// <summary>
        /// image for images, text for text content, formula for inline formulas, table for tables
        /// </summary>
        Table,
        /// <summary>
        /// image for images, text for text content, formula for inline formulas, table for tables
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayoutDetailLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayoutDetailLabel value)
        {
            return value switch
            {
                LayoutDetailLabel.Formula => "formula",
                LayoutDetailLabel.Image => "image",
                LayoutDetailLabel.Table => "table",
                LayoutDetailLabel.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayoutDetailLabel? ToEnum(string value)
        {
            return value switch
            {
                "formula" => LayoutDetailLabel.Formula,
                "image" => LayoutDetailLabel.Image,
                "table" => LayoutDetailLabel.Table,
                "text" => LayoutDetailLabel.Text,
                _ => null,
            };
        }
    }
}