
#nullable enable

namespace ZAI
{
    /// <summary>
    /// Upload purpose<br/>
    /// Default Value: user_data
    /// </summary>
    public enum CreatePaasV4FilesRequestPurpose
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        UserData,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePaasV4FilesRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePaasV4FilesRequestPurpose value)
        {
            return value switch
            {
                CreatePaasV4FilesRequestPurpose.Agent => "agent",
                CreatePaasV4FilesRequestPurpose.UserData => "user_data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePaasV4FilesRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "agent" => CreatePaasV4FilesRequestPurpose.Agent,
                "user_data" => CreatePaasV4FilesRequestPurpose.UserData,
                _ => null,
            };
        }
    }
}