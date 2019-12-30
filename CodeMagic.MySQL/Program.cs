using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CodeMagic.MySQL
{
    static class Program
    {
        public static MainForm DockMainForm { get; set; }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DockMainForm = new MainForm();
            Application.Run(DockMainForm);
        }
    }
}
