using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.PGSql.DevTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 三层代码生成器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ThreeCodeGenerateForm().Show();
        }
    }
}
