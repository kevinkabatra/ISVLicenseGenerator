using ISVLicenseGenerator.Properties;
using Microsoft.VisualBasic.CompilerServices;
using System.Windows.Forms.PropertyGridInternal;

namespace ISVLicenseGeneratorCore
{
    partial class ISVLicenseGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathTB = new System.Windows.Forms.TextBox();
            this.LicenseCodeTB = new System.Windows.Forms.TextBox();
            this.CustomerTB = new System.Windows.Forms.TextBox();
            this.SerialNumberTB = new System.Windows.Forms.TextBox();
            this.PathLbl = new System.Windows.Forms.Label();
            this.UserCountLbl = new System.Windows.Forms.Label();
            this.ExpirationDateLbl = new System.Windows.Forms.Label();
            this.SerialNumberLbl = new System.Windows.Forms.Label();
            this.CustomerTenantLbl = new System.Windows.Forms.Label();
            this.LicenseCodeLbl = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExpirationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UserCount = new System.Windows.Forms.NumericUpDown();
            this.MandatoryLbl = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AzureKeyVaultUrl = new System.Windows.Forms.Label();
            this.AzureKeyVaultTenantId = new System.Windows.Forms.Label();
            this.AzureKeyVaultLabel = new System.Windows.Forms.Label();
            this.AzureKeyVaultClientId = new System.Windows.Forms.Label();
            this.AzureKeyVaultClientSecret = new System.Windows.Forms.Label();
            this.AzureKeyVaultCertificate = new System.Windows.Forms.Label();
            this.AzureKeyVaultUrlTB = new System.Windows.Forms.TextBox();
            this.AzureKeyVaultTenantIdTB = new System.Windows.Forms.TextBox();
            this.AzureKeyVaultClientIdTB = new System.Windows.Forms.TextBox();
            this.AzureKeyVaultClientSecretTB = new System.Windows.Forms.TextBox();
            this.AzureKeyVaultCertificateTB = new System.Windows.Forms.TextBox();
            this.AzureKeyVaultInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserCount)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathTB
            // 
            this.PathTB.BackColor = System.Drawing.SystemColors.Control;
            this.PathTB.Location = new System.Drawing.Point(461, 92);
            this.PathTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PathTB.Name = "PathTB";
            this.PathTB.ReadOnly = true;
            this.PathTB.Size = new System.Drawing.Size(697, 47);
            this.PathTB.TabIndex = 0;
            // 
            // LicenseCodeTB
            // 
            this.LicenseCodeTB.Location = new System.Drawing.Point(461, 164);
            this.LicenseCodeTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.LicenseCodeTB.Name = "LicenseCodeTB";
            this.LicenseCodeTB.Size = new System.Drawing.Size(909, 47);
            this.LicenseCodeTB.TabIndex = 1;
            // 
            // CustomerTB
            // 
            this.CustomerTB.Location = new System.Drawing.Point(461, 234);
            this.CustomerTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CustomerTB.Name = "CustomerTB";
            this.CustomerTB.Size = new System.Drawing.Size(909, 47);
            this.CustomerTB.TabIndex = 2;
            // 
            // SerialNumberTB
            // 
            this.SerialNumberTB.Location = new System.Drawing.Point(461, 304);
            this.SerialNumberTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.SerialNumberTB.Name = "SerialNumberTB";
            this.SerialNumberTB.Size = new System.Drawing.Size(909, 47);
            this.SerialNumberTB.TabIndex = 3;
            // 
            // PathLbl
            // 
            this.PathLbl.AutoSize = true;
            this.PathLbl.Location = new System.Drawing.Point(23, 98);
            this.PathLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(271, 41);
            this.PathLbl.TabIndex = 6;
            this.PathLbl.Text = "Output File Path (*)";
            // 
            // UserCountLbl
            // 
            this.UserCountLbl.AutoSize = true;
            this.UserCountLbl.Location = new System.Drawing.Point(23, 450);
            this.UserCountLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserCountLbl.Name = "UserCountLbl";
            this.UserCountLbl.Size = new System.Drawing.Size(162, 41);
            this.UserCountLbl.TabIndex = 8;
            this.UserCountLbl.Text = "User count";
            // 
            // ExpirationDateLbl
            // 
            this.ExpirationDateLbl.AutoSize = true;
            this.ExpirationDateLbl.Location = new System.Drawing.Point(23, 380);
            this.ExpirationDateLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ExpirationDateLbl.Name = "ExpirationDateLbl";
            this.ExpirationDateLbl.Size = new System.Drawing.Size(216, 41);
            this.ExpirationDateLbl.TabIndex = 9;
            this.ExpirationDateLbl.Text = "Expiration date";
            // 
            // SerialNumberLbl
            // 
            this.SerialNumberLbl.AutoSize = true;
            this.SerialNumberLbl.Location = new System.Drawing.Point(23, 310);
            this.SerialNumberLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SerialNumberLbl.Name = "SerialNumberLbl";
            this.SerialNumberLbl.Size = new System.Drawing.Size(240, 41);
            this.SerialNumberLbl.TabIndex = 10;
            this.SerialNumberLbl.Text = "Serial number (*)";
            // 
            // CustomerTenantLbl
            // 
            this.CustomerTenantLbl.AutoSize = true;
            this.CustomerTenantLbl.Location = new System.Drawing.Point(23, 240);
            this.CustomerTenantLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustomerTenantLbl.Name = "CustomerTenantLbl";
            this.CustomerTenantLbl.Size = new System.Drawing.Size(279, 41);
            this.CustomerTenantLbl.TabIndex = 11;
            this.CustomerTenantLbl.Text = "Customer tenant (*)";
            // 
            // LicenseCodeLbl
            // 
            this.LicenseCodeLbl.AutoSize = true;
            this.LicenseCodeLbl.Location = new System.Drawing.Point(23, 170);
            this.LicenseCodeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LicenseCodeLbl.Name = "LicenseCodeLbl";
            this.LicenseCodeLbl.Size = new System.Drawing.Size(228, 41);
            this.LicenseCodeLbl.TabIndex = 12;
            this.LicenseCodeLbl.Text = "License code (*)";
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(1156, 1053);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(219, 82);
            this.GenerateBtn.TabIndex = 13;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);

            // 
            // OutputTB
            // 
            this.OutputTB.Enabled = false;
            this.OutputTB.Location = new System.Drawing.Point(23, 1143);
            this.OutputTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.ReadOnly = true;
            this.OutputTB.Size = new System.Drawing.Size(1345, 158);
            this.OutputTB.TabIndex = 14;
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(23, 1094);
            this.ResultLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(98, 41);
            this.ResultLbl.TabIndex = 15;
            this.ResultLbl.Text = "Result";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(1175, 88);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(200, 59);
            this.BrowseBtn.TabIndex = 16;
            this.BrowseBtn.Text = "Browse...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // ExpirationDatePicker
            // 
            this.ExpirationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpirationDatePicker.Location = new System.Drawing.Point(461, 374);
            this.ExpirationDatePicker.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ExpirationDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ExpirationDatePicker.Name = "ExpirationDatePicker";
            this.ExpirationDatePicker.Size = new System.Drawing.Size(909, 47);
            this.ExpirationDatePicker.TabIndex = 17;
            this.ExpirationDatePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // UserCount
            // 
            this.UserCount.Location = new System.Drawing.Point(461, 444);
            this.UserCount.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.UserCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.UserCount.Name = "UserCount";
            this.UserCount.Size = new System.Drawing.Size(914, 47);
            this.UserCount.TabIndex = 18;
            // 
            // MandatoryLbl
            // 
            this.MandatoryLbl.AutoSize = true;
            this.MandatoryLbl.Location = new System.Drawing.Point(23, 1027);
            this.MandatoryLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MandatoryLbl.Name = "MandatoryLbl";
            this.MandatoryLbl.Size = new System.Drawing.Size(288, 41);
            this.MandatoryLbl.TabIndex = 19;
            this.MandatoryLbl.Text = " (*) Mandatory fields";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(13, 6, 0, 6);
            this.MainMenuStrip.Size = new System.Drawing.Size(1409, 57);
            this.MainMenuStrip.TabIndex = 20;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 45);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(267, 54);
            this.usageToolStripMenuItem.Text = "Usage";
            // 
            // AzureKeyVaultUrl
            // 
            this.AzureKeyVaultUrl.AutoSize = true;
            this.AzureKeyVaultUrl.Location = new System.Drawing.Point(62, 570);
            this.AzureKeyVaultUrl.Name = "AzureKeyVaultUrl";
            this.AzureKeyVaultUrl.Size = new System.Drawing.Size(201, 41);
            this.AzureKeyVaultUrl.TabIndex = 21;
            this.AzureKeyVaultUrl.Text = "Key Vault URL";
            // 
            // AzureKeyVaultTenantId
            // 
            this.AzureKeyVaultTenantId.AutoSize = true;
            this.AzureKeyVaultTenantId.Location = new System.Drawing.Point(62, 640);
            this.AzureKeyVaultTenantId.Name = "AzureKeyVaultTenantId";
            this.AzureKeyVaultTenantId.Size = new System.Drawing.Size(140, 41);
            this.AzureKeyVaultTenantId.TabIndex = 22;
            this.AzureKeyVaultTenantId.Text = "Tenant Id";
            // 
            // AzureKeyVaultLabel
            // 
            this.AzureKeyVaultLabel.AutoSize = true;
            this.AzureKeyVaultLabel.Location = new System.Drawing.Point(23, 520);
            this.AzureKeyVaultLabel.Name = "AzureKeyVaultLabel";
            this.AzureKeyVaultLabel.Size = new System.Drawing.Size(224, 41);
            this.AzureKeyVaultLabel.TabIndex = 23;
            this.AzureKeyVaultLabel.Text = "Azure Key Vault";
            // 
            // AzureKeyVaultClientId
            // 
            this.AzureKeyVaultClientId.AutoSize = true;
            this.AzureKeyVaultClientId.Location = new System.Drawing.Point(62, 710);
            this.AzureKeyVaultClientId.Name = "AzureKeyVaultClientId";
            this.AzureKeyVaultClientId.Size = new System.Drawing.Size(128, 41);
            this.AzureKeyVaultClientId.TabIndex = 24;
            this.AzureKeyVaultClientId.Text = "Client Id";
            // 
            // AzureKeyVaultClientSecret
            // 
            this.AzureKeyVaultClientSecret.AutoSize = true;
            this.AzureKeyVaultClientSecret.Location = new System.Drawing.Point(62, 780);
            this.AzureKeyVaultClientSecret.Name = "AzureKeyVaultClientSecret";
            this.AzureKeyVaultClientSecret.Size = new System.Drawing.Size(184, 41);
            this.AzureKeyVaultClientSecret.TabIndex = 25;
            this.AzureKeyVaultClientSecret.Text = "Client Secret";
            // 
            // AzureKeyVaultCertificate
            // 
            this.AzureKeyVaultCertificate.AutoSize = true;
            this.AzureKeyVaultCertificate.Location = new System.Drawing.Point(62, 850);
            this.AzureKeyVaultCertificate.Name = "AzureKeyVaultCertificate";
            this.AzureKeyVaultCertificate.Size = new System.Drawing.Size(238, 41);
            this.AzureKeyVaultCertificate.TabIndex = 26;
            this.AzureKeyVaultCertificate.Text = "Certificate Name";
            // 
            // AzureKeyVaultUrlTB
            // 
            this.AzureKeyVaultUrlTB.Location = new System.Drawing.Point(461, 564);
            this.AzureKeyVaultUrlTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AzureKeyVaultUrlTB.Name = "AzureKeyVaultUrlTB";
            this.AzureKeyVaultUrlTB.Size = new System.Drawing.Size(909, 47);
            this.AzureKeyVaultUrlTB.TabIndex = 27;
            // 
            // AzureKeyVaultTenantIdTB
            // 
            this.AzureKeyVaultTenantIdTB.Location = new System.Drawing.Point(461, 634);
            this.AzureKeyVaultTenantIdTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AzureKeyVaultTenantIdTB.Name = "AzureKeyVaultTenantIdTB";
            this.AzureKeyVaultTenantIdTB.Size = new System.Drawing.Size(909, 47);
            this.AzureKeyVaultTenantIdTB.TabIndex = 28;
            // 
            // AzureKeyVaultClientIdTB
            // 
            this.AzureKeyVaultClientIdTB.Location = new System.Drawing.Point(461, 704);
            this.AzureKeyVaultClientIdTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AzureKeyVaultClientIdTB.Name = "AzureKeyVaultClientIdTB";
            this.AzureKeyVaultClientIdTB.Size = new System.Drawing.Size(909, 47);
            this.AzureKeyVaultClientIdTB.TabIndex = 29;
            // 
            // AzureKeyVaultClientSecretTB
            // 
            this.AzureKeyVaultClientSecretTB.Location = new System.Drawing.Point(461, 774);
            this.AzureKeyVaultClientSecretTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AzureKeyVaultClientSecretTB.Name = "AzureKeyVaultClientSecretTB";
            this.AzureKeyVaultClientSecretTB.Size = new System.Drawing.Size(909, 47);
            this.AzureKeyVaultClientSecretTB.TabIndex = 30;
            // 
            // AzureKeyVaultCertificateTB
            // 
            this.AzureKeyVaultCertificateTB.Location = new System.Drawing.Point(461, 844);
            this.AzureKeyVaultCertificateTB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AzureKeyVaultCertificateTB.Name = "AzureKeyVaultCertificateTB";
            this.AzureKeyVaultCertificateTB.Size = new System.Drawing.Size(909, 47);
            this.AzureKeyVaultCertificateTB.TabIndex = 31;
            // 
            // AzureKeyVaultInstructions
            // 
            this.AzureKeyVaultInstructions.AutoSize = true;
            this.AzureKeyVaultInstructions.Location = new System.Drawing.Point(75, 917);
            this.AzureKeyVaultInstructions.Name = "AzureKeyVaultInstructions";
            this.AzureKeyVaultInstructions.Size = new System.Drawing.Size(1187, 82);
            this.AzureKeyVaultInstructions.TabIndex = 32;
            this.AzureKeyVaultInstructions.Text = "Note: Fill out Azure Key Vault details if using a certificate stored in Azure Key" +
    " Vault HSM.\r\nIf using a certificate stored on an USB HSM leave Azure details emp" +
    "ty and click generate.";
            // 
            // ISVLicenseGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 1328);
            this.Controls.Add(this.AzureKeyVaultInstructions);
            this.Controls.Add(this.AzureKeyVaultCertificateTB);
            this.Controls.Add(this.AzureKeyVaultClientSecretTB);
            this.Controls.Add(this.AzureKeyVaultClientIdTB);
            this.Controls.Add(this.AzureKeyVaultTenantIdTB);
            this.Controls.Add(this.AzureKeyVaultUrlTB);
            this.Controls.Add(this.AzureKeyVaultCertificate);
            this.Controls.Add(this.AzureKeyVaultClientSecret);
            this.Controls.Add(this.AzureKeyVaultClientId);
            this.Controls.Add(this.AzureKeyVaultLabel);
            this.Controls.Add(this.AzureKeyVaultTenantId);
            this.Controls.Add(this.AzureKeyVaultUrl);
            this.Controls.Add(this.MandatoryLbl);
            this.Controls.Add(this.UserCount);
            this.Controls.Add(this.ExpirationDatePicker);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.LicenseCodeLbl);
            this.Controls.Add(this.CustomerTenantLbl);
            this.Controls.Add(this.SerialNumberLbl);
            this.Controls.Add(this.ExpirationDateLbl);
            this.Controls.Add(this.UserCountLbl);
            this.Controls.Add(this.PathLbl);
            this.Controls.Add(this.SerialNumberTB);
            this.Controls.Add(this.CustomerTB);
            this.Controls.Add(this.LicenseCodeTB);
            this.Controls.Add(this.PathTB);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = global::ISVLicenseGenerator.Properties.Resources.Icon;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ISVLicenseGeneratorForm";
            this.Text = "ISV License Generator";
            ((System.ComponentModel.ISupportInitialize)(this.UserCount)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTB;
        private System.Windows.Forms.TextBox LicenseCodeTB;
        private System.Windows.Forms.TextBox CustomerTB;
        private System.Windows.Forms.TextBox SerialNumberTB;
        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.Label UserCountLbl;
        private System.Windows.Forms.Label ExpirationDateLbl;
        private System.Windows.Forms.Label SerialNumberLbl;
        private System.Windows.Forms.Label CustomerTenantLbl;
        private System.Windows.Forms.Label LicenseCodeLbl;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DateTimePicker ExpirationDatePicker;
        private System.Windows.Forms.NumericUpDown UserCount;
        private System.Windows.Forms.Label MandatoryLbl;
        private new System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.Label AzureKeyVaultUrl;
        private System.Windows.Forms.Label AzureKeyVaultTenantId;
        private System.Windows.Forms.Label AzureKeyVaultLabel;
        private System.Windows.Forms.Label AzureKeyVaultClientId;
        private System.Windows.Forms.Label AzureKeyVaultClientSecret;
        private System.Windows.Forms.Label AzureKeyVaultCertificate;
        private System.Windows.Forms.TextBox AzureKeyVaultUrlTB;
        private System.Windows.Forms.TextBox AzureKeyVaultTenantIdTB;
        private System.Windows.Forms.TextBox AzureKeyVaultClientIdTB;
        private System.Windows.Forms.TextBox AzureKeyVaultClientSecretTB;
        private System.Windows.Forms.TextBox AzureKeyVaultCertificateTB;
        private System.Windows.Forms.Label AzureKeyVaultInstructions;
    }
}

