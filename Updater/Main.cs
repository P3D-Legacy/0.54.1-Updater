using System;
using System.Net;
using System.Net.Cache;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Threading.Tasks;

namespace Updater
{
    public partial class Main : Form
    {
        private Thread test;

        private delegate void returnResult(string version);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            test = new Thread(() =>
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.CachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
                        Stream stream = client.OpenRead("https://raw.githubusercontent.com/P3D-Legacy/P3D-Legacy/master/2.5DHero/2.5DHero/CurrentVersion.dat");
                        stream.ReadTimeout = 5000;

                        using (StreamReader Reader = new StreamReader(stream))
                        {
                            string CurrentTask = Reader.ReadToEnd();
                            Invoke(new returnResult(result), CurrentTask);
                        }
                    }
                }
                catch (Exception) { Environment.Exit(0); }
            });
            test.IsBackground = true;
            test.Start();
        }

        private void result(string version)
        {
            if (version == "0.54.1")
            {
                Hide();
                UpdatePrompt test = new UpdatePrompt("Indev " + version);
                test.Show();
                test.FormClosed += (s, args) => Close();
            }
            else
                Close();
        }
    }
}