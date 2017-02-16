using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Threading;
using System.Windows.Forms;

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

                        Stream stream = client.OpenRead("https://raw.githubusercontent.com/P3D-Legacy/P3D-Legacy-Data/master/CurrentVersion.dat");
                        stream.ReadTimeout = 5000;

                        using (StreamReader Reader = new StreamReader(stream))
                        {
                            string version = Reader.ReadToEnd();
                            Invoke(new MethodInvoker(delegate
                            {
                                if (version.Trim() == "0.54.1a")
                                {
                                    Hide();
                                    UpdatePrompt test = new UpdatePrompt("Indev " + version);
                                    test.Show();
                                    test.FormClosed += (s, args) => Close();
                                }
                                else
                                    Close();
                            }));
                        }
                    }
                }
                catch (Exception) { Environment.Exit(0); }
            });
            test.IsBackground = true;
            test.Start();
        }
    }
}