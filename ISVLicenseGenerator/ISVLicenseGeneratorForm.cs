using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Dynamics.AX.Framework.Tools.ModelManagement;
using System.Security.Cryptography.X509Certificates;
using Kabatra.D365.AzureKeyVault;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace ISVLicenseGeneratorCore
{
    public partial class ISVLicenseGeneratorForm : Form
    {
        AxUtilConfiguration config;

        public ISVLicenseGeneratorForm()
        {
            InitializeComponent();

            config = new AxUtilConfiguration();

            config.SignatureVersion = 2;

            AzureKeyVaultUrlTB.Text = ConfigurationManager.AppSettings.Get("AzureKeyVaultURL");
            AzureKeyVaultTenantIdTB.Text = ConfigurationManager.AppSettings.Get("AzureKeyVaultTenantId");
            AzureKeyVaultClientIdTB.Text = ConfigurationManager.AppSettings.Get("AzureKeyVaultClientId");
            AzureKeyVaultClientSecretTB.Text = ConfigurationManager.AppSettings.Get("AzureKeyVaultClientSecret");
            AzureKeyVaultCertificateTB.Text = ConfigurationManager.AppSettings.Get("AzureKeyVaultCertificate");
        }

        private async void GenerateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await this.GenerateLicense();
            }
            catch (Exception ex)
            {
                OutputTB.Text = ex.Message;
            }
        }

        private Boolean ValidateFields()
        {
            return !String.IsNullOrEmpty(PathTB.Text) && !String.IsNullOrEmpty(LicenseCodeTB.Text) && !String.IsNullOrEmpty(CustomerTB.Text) && !String.IsNullOrEmpty(SerialNumberTB.Text);
        }

        private bool ValidateAzureFields()
        {
            if (!string.IsNullOrEmpty(AzureKeyVaultCertificateTB.Text))
            {
                if (
                    string.IsNullOrEmpty(AzureKeyVaultTenantIdTB.Text)
                    || string.IsNullOrEmpty(AzureKeyVaultClientIdTB.Text)
                    || string.IsNullOrEmpty(AzureKeyVaultClientSecretTB.Text)
                    || string.IsNullOrEmpty(AzureKeyVaultUrlTB.Text)
                )
                {
                    return false;
                }
            }

            return true;
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "TXT file|*.txt";
            saveFileDialog.Title = "Save license";
            saveFileDialog.ShowDialog();

            if (!String.IsNullOrEmpty(saveFileDialog.FileName))
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();

                PathTB.Text = saveFileDialog.FileName;

                fs.Close();
            }
        }

        private async Task GenerateLicense()
        {
            LicenseInfo licenseInfo = new LicenseInfo
            {
                FilePath = PathTB.Text,
                LicenseCode = LicenseCodeTB.Text,
                Customer = CustomerTB.Text,
                SerialNumber = SerialNumberTB.Text,
                Timestamp = DateTime.Now
            };

            if (ExpirationDatePicker.Value != ExpirationDatePicker.MinDate)
            {
                licenseInfo.ExpirationDate = ExpirationDatePicker.Value;
            }

            if (UserCount.Value > 0)
            {
                licenseInfo.UserCount = (int)UserCount.Value;
            }

            if (!this.ValidateFields())
            {
                MessageBox.Show("Please fill all mandatory fields.");
                throw new System.MissingFieldException("Please fill all mandatory fields.");
            }

            if (!ValidateAzureFields())
            {
                var message = "Please fill all Azure Key Vault fields.";
                MessageBox.Show(message);
                throw new System.MissingFieldException(message);
            }

            AxUtilContext context = new AxUtilContext();

            config.LicenseInfo = licenseInfo;

            AxUtil util = new AxUtil(context, config);

            bool result;
            if (string.IsNullOrEmpty(AzureKeyVaultCertificateTB.Text))
            {
                X509Store store = new X509Store("My", StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

                X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
                X509Certificate2Collection fcollection = (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
                X509Certificate2Collection scollection = X509Certificate2UI.SelectFromCollection(fcollection, "Certificate Select", "Select a certificate from the following list to sign the license", X509SelectionFlag.SingleSelection);

                result = util.GenerateLicense(scollection);
            }
            else
            {
                var client = new Client(AzureKeyVaultUrlTB.Text, AzureKeyVaultTenantIdTB.Text, AzureKeyVaultClientIdTB.Text, AzureKeyVaultClientSecretTB.Text);
                var cryptographyClient = await client.GetCryptographyClient(AzureKeyVaultCertificateTB.Text);
                var publicCertificate = await client.GetPublicCertificate(AzureKeyVaultCertificateTB.Text);
                result = await util.GenerateLicense(publicCertificate, cryptographyClient);
            }

            if (result == true)
            {
                MessageBox.Show(String.Format("License generated successfully. Saved at {0}", PathTB.Text));
                OutputTB.Text = String.Format("License generated successfully. Saved at {0}", PathTB.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/aariste/ISVLicenseGenerator/blob/master/README.md";
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private async void DownloadPublicCertificate_Click(object sender, EventArgs e)
        {
            var client = new Client(AzureKeyVaultUrlTB.Text, AzureKeyVaultTenantIdTB.Text, AzureKeyVaultClientIdTB.Text, AzureKeyVaultClientSecretTB.Text);
            var directoryPath = Path.GetDirectoryName(PathTB.Text);
            var filePath = directoryPath + $"/{AzureKeyVaultCertificateTB.Text}.cer";
            await client.DownloadPublicCertificate(AzureKeyVaultCertificateTB.Text, filePath);
        }
    }
}
