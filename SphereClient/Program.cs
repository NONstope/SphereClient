using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphereClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static String Username;
        public static LoginForm ParentForm;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ParentForm = new LoginForm();
            Application.Run(ParentForm);
        }
    }
}
