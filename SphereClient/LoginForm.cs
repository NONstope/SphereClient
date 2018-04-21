using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphereClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = loginArea;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                {
                       { "login", loginArea.Text },
                       { "pass", passArea.Text },
                       { "mode", "remote" }
                };

                String response = Encoding.UTF8.GetString(webClient.UploadValues("http://localhost/statserver/logic-login.php", postData));
                switch (response)
                {
                    case "Success":
                        Program.Username = loginArea.Text;
                        this.Visible = false;
                        new MainForm().Show();
                        break;
                    default:
                        MessageBox.Show("Error", "Wrong login or password");
                        break;
                }
            }
        }
    }
}
