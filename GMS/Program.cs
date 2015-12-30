using System;
using System.Windows.Forms;

namespace GMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result;
            using (var loginForm = new frmLogin())
                result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // login was successful
                frmMain f = new frmMain();
                f.username = 
                Application.Run(new frmMain());
            }

        }
    }
}
