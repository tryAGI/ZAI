
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Default Value: function
    /// </summary>
    public enum FunctionToolSchemaType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionToolSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionToolSchemaType value)
        {
            return value switch
            {
                FunctionToolSchemaType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionToolSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "function" => FunctionToolSchemaType.Function,
                _ => null,
            };
        }
    }
}