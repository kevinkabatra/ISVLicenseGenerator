namespace Kabatra.D365.AzureKeyVault.UnitTests
{
    internal class Constants
    {
        public static string AzureKeyVaultURL = "";
        public static string AzureKeyVaultTenantId = "";
        public static string AzureKeyVaultClientId = "";
        public static string AzureKeyVaultClientSecret = "";
        public static string AzureKeyVaultCertificate = "";

        public static Client GetClient()
        {
            var client = new Client(
                AzureKeyVaultURL,
                AzureKeyVaultTenantId,
                AzureKeyVaultClientId,
                AzureKeyVaultClientSecret
            );

            return client;
        }
    }
}
