using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterAtomationWa.Classes;

namespace TwitterAtomationWa
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
            Application.ThreadException += Application_ThreadException;
            main = new DM.frmMainForms();
            Application.Run(new frmMain());
        }
        public static DM.frmMainForms main;
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            var strLogFilePath = Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName, "Error.log");
            if (!File.Exists(strLogFilePath))
            {
                StreamWriter str1 = new StreamWriter(File.Create(strLogFilePath));
                str1.Write(e.Exception.ToString() + Environment.NewLine);
                str1.Close();
            }

            StreamWriter str = new StreamWriter(strLogFilePath, true);
            str.Write(e.Exception.ToString() + Environment.NewLine);
            str.Close();
        }
    }
}
