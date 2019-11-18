using CodeMagic.Config;
using CodeMagic.Model;
using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic
{
    static class Program
    {
        public static DBInfoModel CurrentDBInfo = null;
        public static CommonConfig CommonConfig = null;
        public static MainForm MainForm;

        public static void LoadConfig()
        {
            CommonConfig = CommonConfig.LoadCommonConfigOrCreate();
        }

        public static void CreateMainForm()
        {
            MainForm = new MainForm();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (new InitForm().ShowDialog() == DialogResult.OK)
            {
                Application.Run(MainForm);
            }
        }
    }
}
