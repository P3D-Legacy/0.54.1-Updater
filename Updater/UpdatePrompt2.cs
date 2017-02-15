using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Updater
{
    public partial class UpdatePrompt2 : Form
    {
        public UpdatePrompt2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://p3d-legacy.github.io/P3D-Legacy-Launcher/latestRelease");
            Environment.Exit(1);
        }
    }
}