using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Updater
{
    public partial class UpdatePrompt2 : Form
    {
        private bool HaveChecked;

        public UpdatePrompt2(bool haveChecked)
        {
            HaveChecked = haveChecked;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HaveChecked)
                Environment.Exit(3);
            else
                Environment.Exit(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://p3d-legacy.github.io/P3D-Legacy-Launcher/latestRelease");

            if (HaveChecked)
                Environment.Exit(3);
            else
                Environment.Exit(2);
        }
    }
}