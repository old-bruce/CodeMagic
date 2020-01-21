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
            try
            {
                Program.CurrentDBInfo.CodeGenerate.NameSpaceName = tbxNameSpace.Text;
                Program.CurrentDBInfo.CodeGenerate.ModelSuffix = tbxModelSuffix.Text;
                Program.CurrentDBInfo.CodeGenerate.DALSuffix = tbxDALSuffix.Text;
                Program.CurrentDBInfo.CodeGenerate.BLLSuffix = tbxBLLSuffix.Text;
                Program.CurrentDBInfo.CodeGenerate.ShowCopyright = cbxCopyright.Checked;
                MessageBox.Show("保存成功");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CodeGenerateConfigDialogForm_Load(object sender, EventArgs e)
        {
            tbxNameSpace.Text = Program.CurrentDBInfo.CodeGenerate.NameSpaceName;
            tbxModelSuffix.Text = Program.CurrentDBInfo.CodeGenerate.ModelSuffix;
            tbxDALSuffix.Text = Program.CurrentDBInfo.CodeGenerate.DALSuffix;
            tbxBLLSuffix.Text = Program.CurrentDBInfo.CodeGenerate.BLLSuffix;
            cbxCopyright.Checked = Program.CurrentDBInfo.CodeGenerate.ShowCopyright;
        }
    }
}
