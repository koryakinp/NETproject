using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupAssignment
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

                frmLoginForm fLogin = new frmLoginForm();
                fLogin.ShowDialog();

                if (fLogin.DialogResult == DialogResult.OK)
                {
                    Application.Run(new frm_mainForm());
                }
                else if (fLogin.DialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
        }
    }
}
