using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphereClient
{
    public partial class MainForm : Form
    {
        private MouseEventHandler HandlerNotifyClickToShow;
        private MouseEventHandler HandlerNotifyClickToHide;
        private String[] ForbiddenApps =
            { "ApplicationFrameHost",
              "WinStore.App",
              "Video.UI",
              "Microsoft.Photos",
              "devenv" };

        public MainForm()
        {
            InitializeComponent();

            HandlerNotifyClickToShow = new MouseEventHandler(notifyIcon_MouseClickToShow);
            HandlerNotifyClickToHide = new MouseEventHandler(Minimize);

            this.FormClosed += MainForm_FormClosed;
            this.Load += new System.EventHandler(this.Minimize);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.notifyIcon.MouseClick += HandlerNotifyClickToShow;

            GetActiveAppsList();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ParentForm.Close();
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                this.notifyIcon.MouseClick += HandlerNotifyClickToShow;
                this.notifyIcon.MouseClick -= HandlerNotifyClickToHide;
            }
        }

        private void notifyIcon_MouseClickToShow(object sender, MouseEventArgs e)
        {
            this.Show();
            this.notifyIcon.MouseClick -= HandlerNotifyClickToShow;
            this.notifyIcon.MouseClick += HandlerNotifyClickToHide;
            WindowState = FormWindowState.Normal;
        }

        private void GetActiveAppsList()
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle.Length > 0
                    && !ForbiddenApps.Any(x => x == process.ProcessName))
                {
                    programList.Items.Add(
                        System.Char.ToUpper(process.ProcessName[0])
                        + process.ProcessName.Substring(1));
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                {
                       { "username", "Dan" },
                       { "referer", "Ciri" }
                };

                richTextBox1.Text = Encoding.UTF8.GetString(webClient.UploadValues("http://localhost/sphere/index.php", postData));
            }
        }
    }
}
