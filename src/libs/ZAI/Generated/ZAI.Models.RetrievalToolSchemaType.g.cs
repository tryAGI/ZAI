
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Default Value: retrieval
    /// </summary>
    public enum RetrievalToolSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Retrieval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrievalToolSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalToolSchemaType value)
        {
            return value switch
            {
                RetrievalToolSchemaType.Retrieval => "retrieval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalToolSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "retrieval" => RetrievalToolSchemaType.Retrieval,
                _ => null,
            };
        }
    }
}