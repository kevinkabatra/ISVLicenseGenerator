namespace Kabatra.D365.AzureKeyVault
{
    using System.Security.Cryptography.X509Certificates;
    using Azure.Identity;
    using Azure.Security.KeyVault.Certificates;
    using Azure.Security.KeyVault.Keys.Cryptography;

    public class Client
    {
        private readonly CertificateClient certificateClient;

        private readonly ClientSecretCredential credential;

        public Client(string vaultUrl, string tenantId, string clientId, string clientSecret)
        {
            var vaultUri = new Uri(vaultUrl);
            credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            certificateClient = new CertificateClient(vaultUri, credential);
        }

        /// <summary>
        ///     This will be called to download the public certificate which must be embedded
        /// as a resource within your D365 solution.
        /// </summary>
        /// <param name="certificateName"></param>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public async Task DownloadPublicCertificate(string certificateName, string filepath)
        {
            var certificate = await GetCertificate(certificateName);
            var formattedFilePath = filepath.Contains(".cer") ? filepath : filepath + ".cer";

            File.WriteAllBytes(formattedFilePath, certificate.Cer);
        }

        /// <summary>
        ///     This will be used to encrypt/decrypt a string for use in the License File.
        /// </summary>
        /// <param name="certificateName"></param>
        /// <returns></returns>
        public async Task<CryptographyClient> GetCryptographyClient(string certificateName)
        {
            var certificate = await GetCertificate(certificateName);
            var cryptographyClient = new CryptographyClient(certificate.KeyId, credential);

            return cryptographyClient;
        }

        /// <summary>
        ///     This will be used to encrypt/decrypt a string for use in the License File.
        /// </summary>
        /// <param name="certificateName"></param>
        /// <returns></returns>
        public async Task<X509Certificate2> GetPublicCertificate(string certificateName)
        {
            var certificate = await GetCertificate(certificateName);
            return new X509Certificate2(certificate.Cer);
        }

        private async Task<KeyVaultCertificateWithPolicy> GetCertificate(string certificateName)
        {
            var certificate = await certificateClient.GetCertificateAsync(certificateName);
            return certificate;
        }
    }
}
