using CodeMagic.Model;
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
    public partial class CodeGenerateConfigDialogForm : Form
    {
        public CodeGenerateConfigModel CodeGenerateConfig
        {
            get
            {
                return new CodeGenerateConfigModel()
                {
                    NameSpaceName = tbxNameSpace.Text.Trim(),
                    ModelSuffix = tbxModelSuffix.Text.Trim(),
                    DALSuffix = tbxDALSuffix.Text.Trim(),
                    BLLSuffix = tbxBLLSuffix.Text.Trim()
                };
            }
        }

        public CodeGenerateConfigDialogForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CodeGenerateConfigDialogForm_Load(object sender, EventArgs e)
        {
            tbxNameSpace.Text = Program.CurrentDBInfo.CodeGenerate.NameSpaceName;
            tbxModelSuffix.Text = Program.CurrentDBInfo.CodeGenerate.ModelSuffix;
            tbxDALSuffix.Text = Program.CurrentDBInfo.CodeGenerate.DALSuffix;
            tbxBLLSuffix.Text = Program.CurrentDBInfo.CodeGenerate.BLLSuffix;
        }
    }
}
