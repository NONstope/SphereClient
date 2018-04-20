using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphereClient
{
    public partial class MainForm : Form
    {
        private MouseEventHandler HandlerNotifyClickToShow;
        private MouseEventHandler HandlerNotifyClickToHide;

        public MainForm()
        {
            InitializeComponent();

            HandlerNotifyClickToShow = new MouseEventHandler(notifyIcon_MouseClickToShow);
            HandlerNotifyClickToHide = new MouseEventHandler(Minimize);

            this.Load += new System.EventHandler(this.Minimize);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.notifyIcon.MouseClick += HandlerNotifyClickToShow;
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
    }
}
