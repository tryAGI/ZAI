namespace ZAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ZaiClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ZAI_API_KEY") is { Length: > 0 } zaiKeyValue
                ? zaiKeyValue
                : Environment.GetEnvironmentVariable("ZHIPUAI_API_KEY") is { Length: > 0 } zhipuKeyValue
                ? zhipuKeyValue
                : throw new AssertInconclusiveException("ZAI_API_KEY or ZHIPUAI_API_KEY environment variable is not found.");

        var client = new ZaiClient(apiKey);
        
        return client;
    }
}
