using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.Dialogs
{
    public partial class CreateCodeDialogForm : Form
    {
        private ICSharpCode.TextEditor.TextEditorControlEx te;
        private void InitializeTextEditor(string highlightName)
        {
            te = new ICSharpCode.TextEditor.TextEditorControlEx();
            te.Dock = DockStyle.Fill;
            te.Font = new System.Drawing.Font("Courier New", 10F);
            te.Location = new System.Drawing.Point(0, 0);
            te.SetHighlighting(highlightName);
            panelMain.Controls.Add(te);
        }

        public CreateCodeDialogForm(string highlightName)
        {
            InitializeComponent();
            InitializeTextEditor(highlightName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.InitialDirectory = Application.StartupPath + "\\Codes";
            fd.Filter = "C#文件|*.cs|Html文件|*.html|CSS文件|*.cs|JS文件|*.js|所有文件|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(fd.FileName, te.Text, Encoding.UTF8);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
