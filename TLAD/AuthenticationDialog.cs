using System;
using System.Windows.Forms;

namespace TLAD
{
    public partial class WindowsSecurity : Form
    {
        public WindowsSecurity()
        {
            InitializeComponent();
            var logonServer = Environment.GetEnvironmentVariable("LOGONSERVER");
            CredentialProvider.Domain = Environment.UserDomainName;
            CredentialProvider.Username = Environment.UserName;
            ConnectingToLabel.Text = string.Format($"Connecting to {logonServer} as {CredentialProvider.Domain}\\{CredentialProvider.Username}");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            CredentialProvider.Password = PasswordBox.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CredentialProvider.Password = PasswordBox.Text;
            this.Close();
        }
    }
}
