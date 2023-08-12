namespace Kabatra.D365.AzureKeyVault.UnitTests
{
    public class ClientTests
    {
        [Fact]
        public void CanAuthenticateWithManagedIdentity()
        {
            var client = Constants.GetClient();

            Assert.NotNull(client);
        }

        [Fact]
        public async void CanDownloadCertificate()
        {
            var client = Constants.GetClient();
            var filePath = "C:/Temp/PublicCertificate.cer";

            await client.DownloadPublicCertificate(Constants.AzureKeyVaultCertificate, filePath);
        }

        [Fact]
        public async void CanGetCryptographyClient()
        {
            var client = Constants.GetClient();
            var cryptographicClient = await client.GetCryptographyClient(Constants.AzureKeyVaultCertificate);

            Assert.NotNull(cryptographicClient);
        }

        [Fact]
        public async void CanGetPublicCertificate()
        {
            var client = Constants.GetClient();
            var publicCertificate = await client.GetPublicCertificate(Constants.AzureKeyVaultCertificate);

            Assert.NotNull(publicCertificate);
        }
    }
}