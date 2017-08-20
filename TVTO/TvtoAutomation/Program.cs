using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvtoAutomation.Other;

namespace TvtoAutomation
{
    static class Program
    {

        static public Models.UserSelectCommandResult this_user;


        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => rexaError(sender, args.ExceptionObject as Exception);
            Application.ThreadException += (sender, args) => rexaError(sender, args.Exception);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // TOdO
            // new Splash().ShowDialog();

            Application.Run(new Forms.Login());
        }


        private static void rexaError(object sender, Exception e)
        {
            MessageBox.Show("خطای سیستم:\r\n" + e.Message);
        }


    }
}
