using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.Dialogs
{
    public partial class CodeDialogForm : Form
    {
        private ICSharpCode.TextEditor.TextEditorControlEx te;
        private void InitializeTextEditor(string codeName)
        {
            te = new ICSharpCode.TextEditor.TextEditorControlEx();
            te.Dock = DockStyle.Fill;
            te.Font = new System.Drawing.Font("Courier New", 10F);
            te.Location = new System.Drawing.Point(0, 0);
            te.SetHighlighting(codeName);
            this.Controls.Add(te);
        }

        public CodeDialogForm(string codeName, string codeText)
        {
            InitializeComponent();
            InitializeTextEditor(codeName);
            te.Text = codeText;
        }
    }
}
