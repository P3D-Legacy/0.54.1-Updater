using System;
using System.Windows.Forms;

namespace Updater
{
    public partial class UpdatePrompt : Form
    {
        private string VersionInfo;

        public UpdatePrompt(string versionInfo)
        {
            VersionInfo = versionInfo;
            InitializeComponent();
        }

        private void UpdatePrompt_Load(object sender, EventArgs e)
        {
            lblNewVersion.Text = VersionInfo;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Environment.Exit(2);
            else
                Environment.Exit(0);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Hide();
            UpdatePrompt2 test = new UpdatePrompt2(checkBox1.Checked);
            test.Show();
            test.FormClosed += (s, args) => Close();
        }
    }
}